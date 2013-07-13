using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using System.Resources;

namespace Jungler_Timers
{
    public partial class timerJungle : Form
    {
        static int languageSelected = 2;
        List<KeyValuePair<int, SoundPlayer>> soundListFr = new List<KeyValuePair<int, SoundPlayer>>();
        List<KeyValuePair<int, SoundPlayer>> soundListEn = new List<KeyValuePair<int, SoundPlayer>>();
        Form confKeys;
        Keys redAllieKey;
        Keys blueAllieKey;
        Keys redEnemyKey;
        Keys blueEnemyKey;
        Keys drakeKey;
        Keys nashorKey;
        Keys pauseKey;
        Keys resetKey;
        globalKeyboardHook ghk = new globalKeyboardHook();


        #region enums

        enum delays
        {
            buffs = 300,
            drake = 360,
            baron = 420,
        };

        enum languages
        {
            francais = 1,
            english = 2,
        };

        #endregion

        public timerJungle()
        {
            InitializeComponent();
            initialization();
        }

        public void initialization()
        {
            initKeys();
            initAllWindow();
            resetAllTimers();
            initLanguages();
            initMessages();
        }

        #region methods

        private void switchLanguage(int chosenLanguage)
        {
            if (chosenLanguage == 1)
            {
                languageSelected = 1;
                francaisToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
                switchMessages((int)languages.francais);
                toolStrip_pauseAllTimers.Text = "Stopper les timers";
                toolStrip_resetAllTimers.Text = "Remettre à zéro les timers";
                languageToolStripMenuItem.Text = "Langue";
            }
            else if (chosenLanguage == 2)
            {
                languageSelected = 2;
                englishToolStripMenuItem.Checked = true;
                francaisToolStripMenuItem.Checked = false;
                switchMessages((int)languages.english);
                toolStrip_pauseAllTimers.Text = "Pause all timers";
                toolStrip_resetAllTimers.Text = "Reset all timers";
                languageToolStripMenuItem.Text = "Language";
            }
        }

        private void switchMessages(int selectedLanguage)
        {
            if (selectedLanguage == (int)languages.francais)
            {
                button_allyBlue.Text = "Buff bleu allié";
                button_allyRed.Text = "Buff rouge allié";
                button_enemyBlue.Text = "Buff bleu ennemi";
                button_enemyRed.Text = "Buff rouge ennemi";
                button_drake.Text = "Timer drake";
                button_baronNashor.Text = "Timer baron Nashor";
                buttonRedAllieKey.Text = "Configurer touche";
                buttonRedEnemyKey.Text = "Configurer touche";
                buttonBlueAllieKey.Text = "Configurer touche";
                buttonBlueEnemyKey.Text = "Configurer touche";
                buttonDrakeKey.Text = "Configurer touche";
                buttonNashorKey.Text = "Configurer touche";
            }
            else
            {
                button_allyBlue.Text = "Allies blue timer";
                button_allyRed.Text = "Allies red timer";
                button_enemyBlue.Text = "Enemies blue timer";
                button_enemyRed.Text = "Enemies red timer";
                button_drake.Text = "Drake timer";
                button_baronNashor.Text = "Baron Nashor timer";
                buttonRedAllieKey.Text = "Configure key";
                buttonRedEnemyKey.Text = "Configure key";
                buttonBlueAllieKey.Text = "Configure key";
                buttonBlueEnemyKey.Text = "Configure key";
                buttonDrakeKey.Text = "Configure key";
                buttonNashorKey.Text = "Configure key";
            }
        }

        private void playMessage(int messageID)
        {
            try
            {
                SoundPlayer sound = null;
                List<KeyValuePair<int, SoundPlayer>> temp = null;
                if (languageSelected == (int)languages.francais)
                    temp = soundListFr;
                else
                    temp = soundListEn;

                foreach (KeyValuePair<int, SoundPlayer> item in temp)
                {
                    if (messageID == item.Key)
                    {
                        sound = item.Value;
                        sound.Play();
                        return;
                    }
                }
                throw new Exception("Requested sound was not found");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #region keypressed

        void ghk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == redAllieKey)
            {
                if (button_allyRed.state == 0)
                {
                    timerAllyRed.Start();
                    button_allyRed.state = 1;
                }
                else
                {
                    timerAllyRed.Stop();
                    button_allyRed.state = 0;
                }
            }
            else if (e.KeyData == blueAllieKey)
            {
                if (button_allyBlue.state == 0)
                {
                    timerAllyBlue.Start();
                    button_allyBlue.state = 1;
                }
                else
                {
                    timerAllyBlue.Stop();
                    button_allyBlue.state = 0;
                }
            }
            else if (e.KeyData == redEnemyKey)
            {
                if (button_enemyRed.state == 0)
                {
                    timerEnemyRed.Start();
                    button_enemyRed.state = 1;
                }
                else
                {
                    timerEnemyRed.Stop();
                    button_enemyRed.state = 0;
                }
            }
            else if (e.KeyData == blueEnemyKey)
            {
                if (button_enemyBlue.state == 0)
                {
                    timerEnemyBlue.Start();
                    button_enemyBlue.state = 1;
                }
                else
                {
                    timerEnemyBlue.Stop();
                    button_enemyBlue.state = 0;
                }
            }
            else if (e.KeyData == drakeKey)
            {
                if (button_drake.state == 0)
                {
                    timerDrake.Start();
                    button_drake.state = 1;
                }
                else
                {
                    timerDrake.Stop();
                    button_drake.state = 0;
                }
            }
            else if (e.KeyData == nashorKey)
            {
                if (button_baronNashor.state == 0)
                {
                    timerNashor.Start();
                    button_baronNashor.state = 1;
                }
                else
                {
                    timerNashor.Stop();
                    button_baronNashor.state = 0;
                }
            }
            else if (e.KeyData == pauseKey)
                pauseAllTimers();
            else if (e.KeyData == resetKey)
                resetAllTimers();
        }

        #endregion

        #region inits

        private void initKeys()
        {
            redAllieKey = Keys.NumPad1;
            redEnemyKey = Keys.NumPad2;
            blueEnemyKey = Keys.NumPad3;
            blueAllieKey = Keys.NumPad4;
            drakeKey = Keys.NumPad5;
            nashorKey = Keys.NumPad6;
            pauseKey = Keys.NumPad7;
            resetKey = Keys.NumPad8;
            switchKeys();
        }

        private void switchKeys()
        {
            ghk.HookedKeys.Clear();
            ghk.HookedKeys.Add(redAllieKey);
            ghk.HookedKeys.Add(redEnemyKey);
            ghk.HookedKeys.Add(blueAllieKey);
            ghk.HookedKeys.Add(blueEnemyKey);
            ghk.HookedKeys.Add(drakeKey);
            ghk.HookedKeys.Add(nashorKey);
            ghk.HookedKeys.Add(pauseKey);
            ghk.HookedKeys.Add(resetKey);
            ghk.KeyUp -= new KeyEventHandler(ghk_KeyUp);
            ghk.KeyUp += new KeyEventHandler(ghk_KeyUp);
        }

        private void initMessages()
        {
            /* Init fr sound list */
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(1, new SoundPlayer(Jungler_Timers.Properties.Resources.frredBuffAlly30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(2, new SoundPlayer(Jungler_Timers.Properties.Resources.frredBuffAlly0)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(3, new SoundPlayer(Jungler_Timers.Properties.Resources.frblueBuffAlly30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(4, new SoundPlayer(Jungler_Timers.Properties.Resources.frblueBuffAlly0)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(5, new SoundPlayer(Jungler_Timers.Properties.Resources.frredBuffEnemy30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(6, new SoundPlayer(Jungler_Timers.Properties.Resources.frredBuffEnemy0)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(7, new SoundPlayer(Jungler_Timers.Properties.Resources.frblueBuffEnemy30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(8, new SoundPlayer(Jungler_Timers.Properties.Resources.frblueBuffEnemy0)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(9, new SoundPlayer(Jungler_Timers.Properties.Resources.frdrake30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(10, new SoundPlayer(Jungler_Timers.Properties.Resources.frdrake0)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(11, new SoundPlayer(Jungler_Timers.Properties.Resources.frbaronNashor30)));
            soundListFr.Add(new KeyValuePair<int, SoundPlayer>(12, new SoundPlayer(Jungler_Timers.Properties.Resources.frbaronNashor0)));

            /* Init en sound list */
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(1, new SoundPlayer(Jungler_Timers.Properties.Resources.enredBuffAlly30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(2, new SoundPlayer(Jungler_Timers.Properties.Resources.enredBuffAlly0)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(3, new SoundPlayer(Jungler_Timers.Properties.Resources.enblueBuffAlly30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(4, new SoundPlayer(Jungler_Timers.Properties.Resources.enblueBuffAlly0)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(5, new SoundPlayer(Jungler_Timers.Properties.Resources.enredBuffEnemy30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(6, new SoundPlayer(Jungler_Timers.Properties.Resources.enredBuffEnemy0)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(7, new SoundPlayer(Jungler_Timers.Properties.Resources.enblueBuffEnemy30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(8, new SoundPlayer(Jungler_Timers.Properties.Resources.enblueBuffEnemy0)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(9, new SoundPlayer(Jungler_Timers.Properties.Resources.endrake30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(10, new SoundPlayer(Jungler_Timers.Properties.Resources.endrake0)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(11, new SoundPlayer(Jungler_Timers.Properties.Resources.enbaronNashor30)));
            soundListEn.Add(new KeyValuePair<int, SoundPlayer>(12, new SoundPlayer(Jungler_Timers.Properties.Resources.enbaronNashor0)));
        }

        private void initLanguages()
        {
            switchLanguage(2);
            if (languageSelected == (int)languages.francais)
            {
                francaisToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            }
            else if (languageSelected == (int)languages.english)
            {
                englishToolStripMenuItem.Checked = true;
                francaisToolStripMenuItem.Checked = false;
            }
        }

        private void initAllWindow()
        {
            /* Init Form window */
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackgroundImage = Jungler_Timers.Properties.Resources.background;
            this.Icon = System.Drawing.Icon.FromHandle(Jungler_Timers.Properties.Resources.icon.GetHicon());

            /* Init buttons */
            button_allyRed.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            button_allyBlue.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            button_baronNashor.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            button_drake.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            button_enemyBlue.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            button_enemyRed.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonRedAllieKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonRedEnemyKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonBlueEnemyKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonBlueAllieKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonDrakeKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;
            buttonNashorKey.BackgroundImage = Jungler_Timers.Properties.Resources.button;

            /* Init numeric boxes*/
            numeric_redAllieCd.ReadOnly = true;
            numeric_blueAllieCd.ReadOnly = true;
            numeric_redEnemyCd.ReadOnly = true;
            numeric_blueEnemyCd.ReadOnly = true;
            numeric_drake.ReadOnly = true;
            numeric_baronNashor.ReadOnly = true;
            numeric_redAllieCd.InterceptArrowKeys = false;
            numeric_blueAllieCd.InterceptArrowKeys = false;
            numeric_blueEnemyCd.InterceptArrowKeys = false;
            numeric_redEnemyCd.InterceptArrowKeys = false;
            numeric_drake.InterceptArrowKeys = false;
            numeric_baronNashor.InterceptArrowKeys = false;
            numeric_drake.Minimum = 0;
            numeric_baronNashor.Minimum = 0;
            numeric_blueAllieCd.Minimum = 0;
            numeric_blueEnemyCd.Minimum = 0;
            numeric_redAllieCd.Minimum = 0;
            numeric_redEnemyCd.Minimum = 0;

            /* Init delays */
            numeric_drake.Maximum = (int)delays.drake;
            numeric_baronNashor.Maximum = (int)delays.baron;
            numeric_blueAllieCd.Maximum = (int)delays.buffs;
            numeric_blueEnemyCd.Maximum = (int)delays.buffs;
            numeric_redAllieCd.Maximum = (int)delays.buffs;
            numeric_redEnemyCd.Maximum = (int)delays.buffs;

            /* Init labels */
            updateLabels();
        }

        private void pauseAllTimers()
        {
            button_allyBlue.state = 0;
            button_allyRed.state = 0;
            button_enemyBlue.state = 0;
            button_enemyRed.state = 0;
            button_drake.state = 0;
            button_baronNashor.state = 0;
            timerAllyBlue.Stop();
            timerAllyRed.Stop();
            timerEnemyBlue.Stop();
            timerEnemyRed.Stop();
            timerDrake.Stop();
            timerNashor.Stop();
        }

        private void resetAllTimers()
        {
            numeric_redAllieCd.Value = (int)delays.buffs;
            numeric_blueAllieCd.Value = (int)delays.buffs;
            numeric_blueEnemyCd.Value = (int)delays.buffs;
            numeric_redEnemyCd.Value = (int)delays.buffs;
            numeric_drake.Value = (int)delays.drake;
            numeric_baronNashor.Value = (int)delays.baron;
            pauseAllTimers();
        }

        #endregion

        #endregion

        #region events

        private void toolStrip_pauseAllTimers_Click(object sender, EventArgs e)
        {
            pauseAllTimers();

        }

        private void toolStrip_resetAllTimers_Click(object sender, EventArgs e)
        {
            resetAllTimers();
        }

        private void francaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (languageSelected != (int)languages.francais)
                switchLanguage((int)languages.francais);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (languageSelected != (int)languages.english)
                switchLanguage((int)languages.english);
        }

        private void timerRedAllies_Tick(object sender, EventArgs e)
        {
            if (numeric_redAllieCd.Value == 32)
                playMessage(1);
            else if (numeric_redAllieCd.Value == 2)
                playMessage(2);
            if (numeric_redAllieCd.Value != 0)
                numeric_redAllieCd.Value--;
            else
            {
                timerAllyRed.Stop();
                numeric_redAllieCd.Value = (int)delays.buffs;
                button_allyRed.state = 0;
            }
        }

        private void timerBlueAllies_Tick(object sender, EventArgs e)
        {
            if (numeric_blueAllieCd.Value == 32)
                playMessage(3);
            else if (numeric_blueAllieCd.Value == 2)
                playMessage(4);
            if (numeric_blueAllieCd.Value != 0)
                numeric_blueAllieCd.Value--;
            else
            {
                timerAllyBlue.Stop();
                numeric_blueAllieCd.Value = (int)delays.buffs;
                button_allyBlue.state = 0;
            }
        }

        private void timerEnemyRed_Tick(object sender, EventArgs e)
        {
            if (numeric_blueAllieCd.Value == 32)
                playMessage(5);
            else if (numeric_blueAllieCd.Value == 2)
                playMessage(6);
            if (numeric_redEnemyCd.Value != 0)
                numeric_redEnemyCd.Value--;
            else
            {
                timerEnemyRed.Stop();
                numeric_redEnemyCd.Value = (int)delays.buffs;
                button_enemyRed.state = 0;
            }
        }

        private void timerEnemyBlue_Tick(object sender, EventArgs e)
        {
            if (numeric_blueEnemyCd.Value == 32)
                playMessage(7);
            else if (numeric_blueEnemyCd.Value == 2)
                playMessage(8);
            if (numeric_blueEnemyCd.Value != 0)
                numeric_blueEnemyCd.Value--;
            else
            {
                timerEnemyBlue.Stop();
                numeric_blueEnemyCd.Value = (int)delays.buffs;
                button_enemyBlue.state = 0;
            }
        }

        private void timerDrake_Tick(object sender, EventArgs e)
        {
            if (numeric_drake.Value == 32)
                playMessage(9);
            else if (numeric_drake.Value == 2)
                playMessage(10);
            if (numeric_drake.Value != 0)
                numeric_drake.Value--;
            else
            {
                timerDrake.Stop();
                numeric_drake.Value = (int)delays.drake;
                button_drake.state = 0;
            }
        }

        private void timerNashor_Tick(object sender, EventArgs e)
        {
            if (numeric_baronNashor.Value == 32)
                playMessage(11);
            else if (numeric_baronNashor.Value == 2)
                playMessage(12);
            if (numeric_baronNashor.Value != 0)
                numeric_baronNashor.Value--;
            else
            {
                timerNashor.Stop();
                numeric_baronNashor.Value = (int)delays.baron;
                button_baronNashor.state = 0;
            }
        }

        #endregion

        private void button_redAllie_Click(object sender, EventArgs e)
        {
            if (button_allyRed.state == 0)
            {
                timerAllyRed.Start();
                button_allyRed.state = 1;
            }
            else
            {
                timerAllyRed.Stop();
                button_allyRed.state = 0;
            }
        }

        private void button_blueAllie_Click(object sender, EventArgs e)
        {
            if (button_allyBlue.state == 0)
            {
                timerAllyBlue.Start();
                button_allyBlue.state = 1;
            }
            else
            {
                timerAllyBlue.Stop();
                button_allyBlue.state = 0;
            }
        }

        private void button_enemyRed_Click(object sender, EventArgs e)
        {
            if (button_enemyRed.state == 0)
            {
                timerEnemyRed.Start();
                button_enemyRed.state = 1;
            }
            else
            {
                timerEnemyRed.Stop();
                button_enemyRed.state = 0;
            }
        }

        private void button_enemyBlue_Click(object sender, EventArgs e)
        {
            if (button_enemyBlue.state == 0)
            {
                timerEnemyBlue.Start();
                button_enemyBlue.state = 1;
            }
            else
            {
                timerEnemyBlue.Stop();
                button_enemyBlue.state = 0;
            }
        }

        private void button_drake_Click(object sender, EventArgs e)
        {
            if (button_drake.state == 0)
            {
                timerDrake.Start();
                button_drake.state = 1;
            }
            else
            {
                timerDrake.Stop();
                button_drake.state = 0;
            }
        }

        private void button_baronNashor_Click(object sender, EventArgs e)
        {
            if (button_baronNashor.state == 0)
            {
                timerNashor.Start();
                button_baronNashor.state = 1;
            }
            else
            {
                timerNashor.Stop();
                button_baronNashor.state = 0;
            }
        }

        private void pictureBox_resetAllyRed_Click(object sender, EventArgs e)
        {
            timerAllyRed.Stop();
            numeric_redAllieCd.Value = (int)delays.buffs;
            button_allyRed.state = 0;
        }

        private void pictureBox_resetAllyBlue_Click(object sender, EventArgs e)
        {
            timerAllyBlue.Stop();
            numeric_blueAllieCd.Value = (int)delays.buffs;
            button_allyBlue.state = 0;
        }

        private void pictureBox_resetEnemyRed_Click(object sender, EventArgs e)
        {
            timerEnemyRed.Stop();
            numeric_redEnemyCd.Value = (int)delays.buffs;
            button_enemyRed.state = 0;
        }

        private void pictureBox_resetEnemyBlue_Click(object sender, EventArgs e)
        {
            timerEnemyBlue.Stop();
            numeric_blueEnemyCd.Value = (int)delays.buffs;
            button_enemyBlue.state = 0;
        }

        private void pictureBox_resetNashor_Click(object sender, EventArgs e)
        {
            timerDrake.Stop();
            numeric_drake.Value = (int)delays.buffs;
            button_drake.state = 0;
        }

        private void pictureBox_resetDrake_Click(object sender, EventArgs e)
        {
            timerNashor.Stop();
            numeric_baronNashor.Value = (int)delays.buffs;
            button_baronNashor.state = 0;
        }

        private void pictureBox_resetEnemyRed_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetEnemyRed.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_resetDrake_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetDrake.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_resetNashor_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetNashor.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox_resetEnemyBlue_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetEnemyBlue.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox_resetAllyRed_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetAllyRed.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox_resetAllyBlue_MouseHover(object sender, EventArgs e)
        {
            pictureBox_resetAllyBlue.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox_resetAll_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_resetAllyBlue.BorderStyle = BorderStyle.None;
            pictureBox_resetAllyRed.BorderStyle = BorderStyle.None;
            pictureBox_resetEnemyBlue.BorderStyle = BorderStyle.None;
            pictureBox_resetNashor.BorderStyle = BorderStyle.None;
            pictureBox_resetDrake.BorderStyle = BorderStyle.None;
            pictureBox_resetEnemyRed.BorderStyle = BorderStyle.None;
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {
            try
            {
                if (buttonRedAllieKey.state == 1)
                {
                    buttonRedAllieKey.state = 0;
                    redAllieKey = e.KeyCode;
                }
                else if (buttonRedEnemyKey.state == 1)
                {
                    buttonRedEnemyKey.state = 0;
                    redEnemyKey = e.KeyCode;
                }
                else if (buttonBlueAllieKey.state == 1)
                {
                    buttonBlueAllieKey.state = 0;
                    blueAllieKey = e.KeyCode;
                }
                else if (buttonBlueEnemyKey.state == 1)
                {
                    buttonBlueEnemyKey.state = 0;
                    blueEnemyKey = e.KeyCode;
                }
                else if (buttonDrakeKey.state == 1)
                {
                    buttonDrakeKey.state = 0;
                    drakeKey = e.KeyCode;
                }
                else if (buttonNashorKey.state == 1)
                {
                    buttonNashorKey.state = 0;
                    nashorKey = e.KeyCode;
                }
                switchKeys();
                updateLabels();
                confKeys.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void updateLabels()
        {
            KeysConverter kc = new KeysConverter();
            labelRedAllie.Text = kc.ConvertToString(redAllieKey);
            labelBlueAllie.Text = kc.ConvertToString(blueAllieKey);
            labelRedEnemy.Text = kc.ConvertToString(redEnemyKey);
            labelBlueEnemy.Text = kc.ConvertToString(blueEnemyKey);
            labelNashor.Text = kc.ConvertToString(nashorKey);
            labelDrake.Text = kc.ConvertToString(drakeKey);
            labelBlueAllie.Update();
            labelRedAllie.Update();
            labelBlueEnemy.Update();
            labelRedEnemy.Update();
            labelNashor.Update();
            labelDrake.Update();
        }

        private void configureHotkeys()
        {
            try
            {
                confKeys = new Form();
                Label box = new Label();
                box.Font = new Font("Segoe UI", 15);
                box.Width = 350;
                box.Height = 150;
                if (languageSelected == 1)
                    box.Text = "Appuyez sur une touche";
                else
                    box.Text = "Press a key";
                box.Location = new Point(110, 35);
                confKeys.Icon = System.Drawing.Icon.FromHandle(Jungler_Timers.Properties.Resources.icon.GetHicon());
                confKeys.Width = 350;
                confKeys.Height = 150;
                confKeys.KeyUp += new KeyEventHandler(keyPressed);
                confKeys.Controls.Add(box);
                confKeys.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
        }

        private void buttonRedAllieKey_Click(object sender, EventArgs e)
        {
            buttonRedAllieKey.state = 1;
            configureHotkeys();
        }

        private void buttonRedEnemyKey_Click(object sender, EventArgs e)
        {
            buttonRedEnemyKey.state = 1;
            configureHotkeys();
        }

        private void buttonBlueAllieKey_Click(object sender, EventArgs e)
        {
            buttonBlueAllieKey.state = 1;
            configureHotkeys();
        }

        private void buttonBlueEnemyKey_Click(object sender, EventArgs e)
        {
            buttonBlueEnemyKey.state = 1;
            configureHotkeys();
        }

        private void buttonDrakeKey_Click(object sender, EventArgs e)
        {
            buttonDrakeKey.state = 1;
            configureHotkeys();
        }

        private void buttonNashorKey_Click(object sender, EventArgs e)
        {
            buttonNashorKey.state = 1;
            configureHotkeys();
        }
    }
}
