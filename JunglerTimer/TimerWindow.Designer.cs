namespace Jungler_Timers
{
    partial class timerJungle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timerJungle));
            this.timerAllyRed = new System.Windows.Forms.Timer(this.components);
            this.timerAllyBlue = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_timers = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_parent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_pauseAllTimers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_resetAllTimers = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.francaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerEnemyRed = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyBlue = new System.Windows.Forms.Timer(this.components);
            this.timerDrake = new System.Windows.Forms.Timer(this.components);
            this.timerNashor = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_resetAllyBlue = new System.Windows.Forms.PictureBox();
            this.pictureBox_resetEnemyRed = new System.Windows.Forms.PictureBox();
            this.pictureBox_resetEnemyBlue = new System.Windows.Forms.PictureBox();
            this.pictureBox_resetDrake = new System.Windows.Forms.PictureBox();
            this.pictureBox_resetNashor = new System.Windows.Forms.PictureBox();
            this.pictureBox_resetAllyRed = new System.Windows.Forms.PictureBox();
            this.numeric_drake = new Jungler_Timers.myNumericUpDown();
            this.numeric_baronNashor = new Jungler_Timers.myNumericUpDown();
            this.button_drake = new Jungler_Timers.myButton();
            this.button_baronNashor = new Jungler_Timers.myButton();
            this.numeric_redEnemyCd = new Jungler_Timers.myNumericUpDown();
            this.numeric_blueEnemyCd = new Jungler_Timers.myNumericUpDown();
            this.button_enemyBlue = new Jungler_Timers.myButton();
            this.button_enemyRed = new Jungler_Timers.myButton();
            this.numeric_blueAllieCd = new Jungler_Timers.myNumericUpDown();
            this.numeric_redAllieCd = new Jungler_Timers.myNumericUpDown();
            this.button_allyBlue = new Jungler_Timers.myButton();
            this.button_allyRed = new Jungler_Timers.myButton();
            this.menuStrip_timers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetAllyBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetEnemyRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetEnemyBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetDrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetNashor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetAllyRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_drake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_baronNashor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_redEnemyCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blueEnemyCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blueAllieCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_redAllieCd)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAllyRed
            // 
            this.timerAllyRed.Enabled = true;
            this.timerAllyRed.Interval = 1000;
            this.timerAllyRed.Tick += new System.EventHandler(this.timerRedAllies_Tick);
            // 
            // timerAllyBlue
            // 
            this.timerAllyBlue.Enabled = true;
            this.timerAllyBlue.Interval = 1000;
            this.timerAllyBlue.Tick += new System.EventHandler(this.timerBlueAllies_Tick);
            // 
            // menuStrip_timers
            // 
            this.menuStrip_timers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_parent,
            this.optionsToolStripMenuItem});
            this.menuStrip_timers.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_timers.Name = "menuStrip_timers";
            this.menuStrip_timers.Size = new System.Drawing.Size(615, 24);
            this.menuStrip_timers.TabIndex = 1;
            this.menuStrip_timers.Text = "menuStrip1";
            // 
            // toolStripMenuItem_parent
            // 
            this.toolStripMenuItem_parent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_pauseAllTimers,
            this.toolStrip_resetAllTimers});
            this.toolStripMenuItem_parent.Name = "toolStripMenuItem_parent";
            this.toolStripMenuItem_parent.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem_parent.Text = "Timers";
            // 
            // toolStrip_pauseAllTimers
            // 
            this.toolStrip_pauseAllTimers.Name = "toolStrip_pauseAllTimers";
            this.toolStrip_pauseAllTimers.Size = new System.Drawing.Size(198, 22);
            this.toolStrip_pauseAllTimers.Text = "Pause all timers          F7";
            this.toolStrip_pauseAllTimers.Click += new System.EventHandler(this.toolStrip_pauseAllTimers_Click);
            // 
            // toolStrip_resetAllTimers
            // 
            this.toolStrip_resetAllTimers.Name = "toolStrip_resetAllTimers";
            this.toolStrip_resetAllTimers.Size = new System.Drawing.Size(198, 22);
            this.toolStrip_resetAllTimers.Text = "Reset all timers           F8";
            this.toolStrip_resetAllTimers.Click += new System.EventHandler(this.toolStrip_resetAllTimers_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.francaisToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // francaisToolStripMenuItem
            // 
            this.francaisToolStripMenuItem.Name = "francaisToolStripMenuItem";
            this.francaisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.francaisToolStripMenuItem.Text = "Francais";
            this.francaisToolStripMenuItem.Click += new System.EventHandler(this.francaisToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // timerEnemyRed
            // 
            this.timerEnemyRed.Enabled = true;
            this.timerEnemyRed.Interval = 1000;
            this.timerEnemyRed.Tick += new System.EventHandler(this.timerEnemyRed_Tick);
            // 
            // timerEnemyBlue
            // 
            this.timerEnemyBlue.Enabled = true;
            this.timerEnemyBlue.Interval = 1000;
            this.timerEnemyBlue.Tick += new System.EventHandler(this.timerEnemyBlue_Tick);
            // 
            // timerDrake
            // 
            this.timerDrake.Enabled = true;
            this.timerDrake.Interval = 1000;
            this.timerDrake.Tick += new System.EventHandler(this.timerDrake_Tick);
            // 
            // timerNashor
            // 
            this.timerNashor.Enabled = true;
            this.timerNashor.Interval = 1000;
            this.timerNashor.Tick += new System.EventHandler(this.timerNashor_Tick);
            // 
            // pictureBox_resetAllyBlue
            // 
            this.pictureBox_resetAllyBlue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetAllyBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetAllyBlue.Image")));
            this.pictureBox_resetAllyBlue.Location = new System.Drawing.Point(180, 242);
            this.pictureBox_resetAllyBlue.Name = "pictureBox_resetAllyBlue";
            this.pictureBox_resetAllyBlue.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetAllyBlue.TabIndex = 21;
            this.pictureBox_resetAllyBlue.TabStop = false;
            this.pictureBox_resetAllyBlue.Click += new System.EventHandler(this.pictureBox_resetAllyBlue_Click);
            this.pictureBox_resetAllyBlue.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetAllyBlue.MouseHover += new System.EventHandler(this.pictureBox_resetAllyBlue_MouseHover);
            // 
            // pictureBox_resetEnemyRed
            // 
            this.pictureBox_resetEnemyRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetEnemyRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetEnemyRed.Image")));
            this.pictureBox_resetEnemyRed.Location = new System.Drawing.Point(550, 113);
            this.pictureBox_resetEnemyRed.Name = "pictureBox_resetEnemyRed";
            this.pictureBox_resetEnemyRed.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetEnemyRed.TabIndex = 20;
            this.pictureBox_resetEnemyRed.TabStop = false;
            this.pictureBox_resetEnemyRed.Click += new System.EventHandler(this.pictureBox_resetEnemyRed_Click);
            this.pictureBox_resetEnemyRed.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetEnemyRed.MouseHover += new System.EventHandler(this.pictureBox_resetEnemyRed_MouseHover);
            // 
            // pictureBox_resetEnemyBlue
            // 
            this.pictureBox_resetEnemyBlue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetEnemyBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetEnemyBlue.Image")));
            this.pictureBox_resetEnemyBlue.Location = new System.Drawing.Point(550, 242);
            this.pictureBox_resetEnemyBlue.Name = "pictureBox_resetEnemyBlue";
            this.pictureBox_resetEnemyBlue.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetEnemyBlue.TabIndex = 19;
            this.pictureBox_resetEnemyBlue.TabStop = false;
            this.pictureBox_resetEnemyBlue.Click += new System.EventHandler(this.pictureBox_resetEnemyBlue_Click);
            this.pictureBox_resetEnemyBlue.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetEnemyBlue.MouseHover += new System.EventHandler(this.pictureBox_resetEnemyBlue_MouseHover);
            // 
            // pictureBox_resetDrake
            // 
            this.pictureBox_resetDrake.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetDrake.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetDrake.Image")));
            this.pictureBox_resetDrake.Location = new System.Drawing.Point(278, 363);
            this.pictureBox_resetDrake.Name = "pictureBox_resetDrake";
            this.pictureBox_resetDrake.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetDrake.TabIndex = 18;
            this.pictureBox_resetDrake.TabStop = false;
            this.pictureBox_resetDrake.Click += new System.EventHandler(this.pictureBox_resetDrake_Click);
            this.pictureBox_resetDrake.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetDrake.MouseHover += new System.EventHandler(this.pictureBox_resetDrake_MouseHover);
            // 
            // pictureBox_resetNashor
            // 
            this.pictureBox_resetNashor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetNashor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetNashor.Image")));
            this.pictureBox_resetNashor.Location = new System.Drawing.Point(490, 363);
            this.pictureBox_resetNashor.Name = "pictureBox_resetNashor";
            this.pictureBox_resetNashor.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetNashor.TabIndex = 17;
            this.pictureBox_resetNashor.TabStop = false;
            this.pictureBox_resetNashor.Click += new System.EventHandler(this.pictureBox_resetNashor_Click);
            this.pictureBox_resetNashor.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetNashor.MouseHover += new System.EventHandler(this.pictureBox_resetNashor_MouseHover);
            // 
            // pictureBox_resetAllyRed
            // 
            this.pictureBox_resetAllyRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_resetAllyRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_resetAllyRed.Image")));
            this.pictureBox_resetAllyRed.Location = new System.Drawing.Point(180, 112);
            this.pictureBox_resetAllyRed.Name = "pictureBox_resetAllyRed";
            this.pictureBox_resetAllyRed.Size = new System.Drawing.Size(17, 19);
            this.pictureBox_resetAllyRed.TabIndex = 16;
            this.pictureBox_resetAllyRed.TabStop = false;
            this.pictureBox_resetAllyRed.Click += new System.EventHandler(this.pictureBox_resetAllyRed_Click);
            this.pictureBox_resetAllyRed.MouseLeave += new System.EventHandler(this.pictureBox_resetAll_MouseLeave);
            this.pictureBox_resetAllyRed.MouseHover += new System.EventHandler(this.pictureBox_resetAllyRed_MouseHover);
            // 
            // numeric_drake
            // 
            this.numeric_drake.Location = new System.Drawing.Point(147, 363);
            this.numeric_drake.Name = "numeric_drake";
            this.numeric_drake.Size = new System.Drawing.Size(125, 20);
            this.numeric_drake.TabIndex = 15;
            // 
            // numeric_baronNashor
            // 
            this.numeric_baronNashor.Location = new System.Drawing.Point(359, 363);
            this.numeric_baronNashor.Name = "numeric_baronNashor";
            this.numeric_baronNashor.Size = new System.Drawing.Size(125, 20);
            this.numeric_baronNashor.TabIndex = 14;
            // 
            // button_drake
            // 
            this.button_drake.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_drake.ForeColor = System.Drawing.Color.White;
            this.button_drake.Location = new System.Drawing.Point(147, 311);
            this.button_drake.Name = "button_drake";
            this.button_drake.Size = new System.Drawing.Size(125, 35);
            this.button_drake.state = 0;
            this.button_drake.TabIndex = 13;
            this.button_drake.Text = "Drake timer";
            this.button_drake.UseVisualStyleBackColor = true;
            this.button_drake.Click += new System.EventHandler(this.button_drake_Click);
            // 
            // button_baronNashor
            // 
            this.button_baronNashor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baronNashor.ForeColor = System.Drawing.Color.White;
            this.button_baronNashor.Location = new System.Drawing.Point(359, 311);
            this.button_baronNashor.Name = "button_baronNashor";
            this.button_baronNashor.Size = new System.Drawing.Size(125, 35);
            this.button_baronNashor.state = 0;
            this.button_baronNashor.TabIndex = 12;
            this.button_baronNashor.Text = "Baron Nashor timer";
            this.button_baronNashor.UseVisualStyleBackColor = true;
            this.button_baronNashor.Click += new System.EventHandler(this.button_baronNashor_Click);
            // 
            // numeric_redEnemyCd
            // 
            this.numeric_redEnemyCd.Location = new System.Drawing.Point(419, 112);
            this.numeric_redEnemyCd.Name = "numeric_redEnemyCd";
            this.numeric_redEnemyCd.Size = new System.Drawing.Size(125, 20);
            this.numeric_redEnemyCd.TabIndex = 11;
            // 
            // numeric_blueEnemyCd
            // 
            this.numeric_blueEnemyCd.Location = new System.Drawing.Point(419, 242);
            this.numeric_blueEnemyCd.Name = "numeric_blueEnemyCd";
            this.numeric_blueEnemyCd.Size = new System.Drawing.Size(125, 20);
            this.numeric_blueEnemyCd.TabIndex = 10;
            // 
            // button_enemyBlue
            // 
            this.button_enemyBlue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enemyBlue.ForeColor = System.Drawing.Color.White;
            this.button_enemyBlue.Location = new System.Drawing.Point(419, 181);
            this.button_enemyBlue.Name = "button_enemyBlue";
            this.button_enemyBlue.Size = new System.Drawing.Size(125, 35);
            this.button_enemyBlue.state = 0;
            this.button_enemyBlue.TabIndex = 9;
            this.button_enemyBlue.Text = "Enemies blue timer";
            this.button_enemyBlue.UseVisualStyleBackColor = true;
            this.button_enemyBlue.Click += new System.EventHandler(this.button_enemyBlue_Click);
            // 
            // button_enemyRed
            // 
            this.button_enemyRed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enemyRed.ForeColor = System.Drawing.Color.White;
            this.button_enemyRed.Location = new System.Drawing.Point(419, 54);
            this.button_enemyRed.Name = "button_enemyRed";
            this.button_enemyRed.Size = new System.Drawing.Size(125, 35);
            this.button_enemyRed.state = 0;
            this.button_enemyRed.TabIndex = 8;
            this.button_enemyRed.Text = "Enemies red timer";
            this.button_enemyRed.UseVisualStyleBackColor = true;
            this.button_enemyRed.Click += new System.EventHandler(this.button_enemyRed_Click);
            // 
            // numeric_blueAllieCd
            // 
            this.numeric_blueAllieCd.Location = new System.Drawing.Point(48, 242);
            this.numeric_blueAllieCd.Name = "numeric_blueAllieCd";
            this.numeric_blueAllieCd.Size = new System.Drawing.Size(125, 20);
            this.numeric_blueAllieCd.TabIndex = 7;
            // 
            // numeric_redAllieCd
            // 
            this.numeric_redAllieCd.Location = new System.Drawing.Point(48, 112);
            this.numeric_redAllieCd.Name = "numeric_redAllieCd";
            this.numeric_redAllieCd.Size = new System.Drawing.Size(125, 20);
            this.numeric_redAllieCd.TabIndex = 6;
            // 
            // button_allyBlue
            // 
            this.button_allyBlue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_allyBlue.ForeColor = System.Drawing.Color.White;
            this.button_allyBlue.Location = new System.Drawing.Point(48, 181);
            this.button_allyBlue.Name = "button_allyBlue";
            this.button_allyBlue.Size = new System.Drawing.Size(125, 35);
            this.button_allyBlue.state = 0;
            this.button_allyBlue.TabIndex = 5;
            this.button_allyBlue.Text = "Allies blue timer";
            this.button_allyBlue.UseVisualStyleBackColor = true;
            this.button_allyBlue.Click += new System.EventHandler(this.button_blueAllie_Click);
            // 
            // button_allyRed
            // 
            this.button_allyRed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_allyRed.ForeColor = System.Drawing.Color.White;
            this.button_allyRed.Location = new System.Drawing.Point(48, 54);
            this.button_allyRed.Name = "button_allyRed";
            this.button_allyRed.Size = new System.Drawing.Size(125, 35);
            this.button_allyRed.state = 0;
            this.button_allyRed.TabIndex = 4;
            this.button_allyRed.Text = "Allies red timer";
            this.button_allyRed.UseVisualStyleBackColor = true;
            this.button_allyRed.Click += new System.EventHandler(this.button_redAllie_Click);
            // 
            // timerJungle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 414);
            this.Controls.Add(this.pictureBox_resetAllyBlue);
            this.Controls.Add(this.pictureBox_resetEnemyRed);
            this.Controls.Add(this.pictureBox_resetEnemyBlue);
            this.Controls.Add(this.pictureBox_resetDrake);
            this.Controls.Add(this.pictureBox_resetNashor);
            this.Controls.Add(this.pictureBox_resetAllyRed);
            this.Controls.Add(this.numeric_drake);
            this.Controls.Add(this.numeric_baronNashor);
            this.Controls.Add(this.button_drake);
            this.Controls.Add(this.button_baronNashor);
            this.Controls.Add(this.numeric_redEnemyCd);
            this.Controls.Add(this.numeric_blueEnemyCd);
            this.Controls.Add(this.button_enemyBlue);
            this.Controls.Add(this.button_enemyRed);
            this.Controls.Add(this.numeric_blueAllieCd);
            this.Controls.Add(this.numeric_redAllieCd);
            this.Controls.Add(this.button_allyBlue);
            this.Controls.Add(this.button_allyRed);
            this.Controls.Add(this.menuStrip_timers);
            this.MainMenuStrip = this.menuStrip_timers;
            this.Name = "timerJungle";
            this.Text = "Jungle Timer";
            this.menuStrip_timers.ResumeLayout(false);
            this.menuStrip_timers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetAllyBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetEnemyRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetEnemyBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetDrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetNashor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resetAllyRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_drake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_baronNashor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_redEnemyCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blueEnemyCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blueAllieCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_redAllieCd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAllyRed;
        private System.Windows.Forms.Timer timerAllyBlue;
        private System.Windows.Forms.MenuStrip menuStrip_timers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_parent;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_resetAllTimers;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_pauseAllTimers;
        private myButton button_allyRed;
        private myButton button_allyBlue;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem francaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private myNumericUpDown numeric_redAllieCd;
        private myNumericUpDown numeric_blueAllieCd;
        private myButton button_enemyRed;
        private myButton button_enemyBlue;
        private myNumericUpDown numeric_blueEnemyCd;
        private myNumericUpDown numeric_redEnemyCd;
        private myButton button_baronNashor;
        private myButton button_drake;
        private myNumericUpDown numeric_baronNashor;
        private myNumericUpDown numeric_drake;
        private System.Windows.Forms.Timer timerEnemyRed;
        private System.Windows.Forms.Timer timerEnemyBlue;
        private System.Windows.Forms.Timer timerDrake;
        private System.Windows.Forms.Timer timerNashor;
        private System.Windows.Forms.PictureBox pictureBox_resetAllyRed;
        private System.Windows.Forms.PictureBox pictureBox_resetNashor;
        private System.Windows.Forms.PictureBox pictureBox_resetDrake;
        private System.Windows.Forms.PictureBox pictureBox_resetEnemyBlue;
        private System.Windows.Forms.PictureBox pictureBox_resetEnemyRed;
        private System.Windows.Forms.PictureBox pictureBox_resetAllyBlue;
    }
}

