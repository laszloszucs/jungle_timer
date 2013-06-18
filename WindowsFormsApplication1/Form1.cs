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

namespace Jungler_Timers
{
    public partial class timerJungle : Form
    {
        static int language = 2;
        static String project_name = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
        static String path = Directory.GetCurrentDirectory();
        List<KeyValuePair<int, string>> messageList = new List<KeyValuePair<int, string>>();
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
            project_name = project_name.Substring(0, project_name.Length - 4);
            initAllNumeric();
            resetAllTimers();
            initLanguages();
            initMessages();
            initKeys();
        }

        #region methods

        private void switchLanguage(int chosenLanguage)
        {
            if (chosenLanguage == 1)
            {
                language = 1;
                francaisToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            }
            else if (chosenLanguage == 2)
            {
                language = 2;
                englishToolStripMenuItem.Checked = true;
                francaisToolStripMenuItem.Checked = false;
            }
        }

        private void playMessage(int length, int messageID)
        {
            string chosenLanguageDir = "";
            string soundsPath = "";
            string chosenMessage = "";

            if (language == (int)languages.francais)
                chosenLanguageDir = "fr\\";
            else if (language == (int)languages.english)
                chosenLanguageDir = "en\\";
            soundsPath += path.Substring(0, path.LastIndexOf(project_name.Remove(project_name.Length - 1)));
            soundsPath += project_name + "\\";
            foreach (KeyValuePair<int, string> item in messageList)
            {
                if (messageID == item.Key)
                    chosenMessage = item.Value;
            }
            SoundPlayer sound = new SoundPlayer(soundsPath + "obj\\sounds\\" + chosenLanguageDir + chosenMessage + length.ToString() + ".WAV");
            sound.Play();
        }

        #region keypressed

        void ghk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
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
            else if (e.KeyData == Keys.F2)
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
            else if (e.KeyData == Keys.F3)
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
            else if (e.KeyData == Keys.F4)
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
            else if (e.KeyData == Keys.F5)
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
            else if (e.KeyData == Keys.F6)
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
        }

        #endregion

        #region inits

        private void initKeys()
        {
            ghk.HookedKeys.Add(Keys.F1);
            ghk.HookedKeys.Add(Keys.F2);
            ghk.HookedKeys.Add(Keys.F3);
            ghk.HookedKeys.Add(Keys.F4);
            ghk.HookedKeys.Add(Keys.F5);
            ghk.HookedKeys.Add(Keys.F6);
            ghk.KeyUp += new KeyEventHandler(ghk_KeyUp);
        }

        private void initMessages()
        {
            messageList.Add(new KeyValuePair<int, string>(1, "redBuffAlly"));
            messageList.Add(new KeyValuePair<int, string>(2, "blueBuffAlly"));
            messageList.Add(new KeyValuePair<int, string>(3, "redBuffEnemy"));
            messageList.Add(new KeyValuePair<int, string>(4, "blueBuffEnemy"));
            messageList.Add(new KeyValuePair<int, string>(5, "drake"));
            messageList.Add(new KeyValuePair<int, string>(6, "baronNashor"));
        }

        private void initLanguages()
        {
            if (language == (int)languages.francais)
            {
                francaisToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            }
            else if (language == (int)languages.english)
            {
                englishToolStripMenuItem.Checked = true;
                francaisToolStripMenuItem.Checked = false;
            }
        }

        private void initAllNumeric()
        {
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
            numeric_drake.Maximum = (int)delays.drake;
            numeric_baronNashor.Maximum = (int)delays.baron;
            numeric_blueAllieCd.Maximum = (int)delays.buffs;
            numeric_blueEnemyCd.Maximum = (int)delays.buffs;
            numeric_redAllieCd.Maximum = (int)delays.buffs;
            numeric_redEnemyCd.Maximum = (int)delays.buffs;
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
            switchLanguage((int)languages.francais);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchLanguage((int)languages.english);
        }

        private void timerRedAllies_Tick(object sender, EventArgs e)
        {
            if (numeric_redAllieCd.Value == 32)
                playMessage(30, 1);
            else if (numeric_redAllieCd.Value == 2)
                playMessage(0, 1);
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
                playMessage(30, 2);
            else if (numeric_blueAllieCd.Value == 2)
                playMessage(0, 2);
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
                playMessage(30, 3);
            else if (numeric_blueAllieCd.Value == 2)
                playMessage(0, 3);
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
                playMessage(30, 4);
            else if (numeric_blueEnemyCd.Value == 2)
                playMessage(0, 4);
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
                playMessage(30, 5);
            else if (numeric_drake.Value == 2)
                playMessage(0, 5);
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
                playMessage(30, 6);
            else if (numeric_baronNashor.Value == 2)
                playMessage(0, 6);
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


    }
}
