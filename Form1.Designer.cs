namespace Classified_Mission
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Key1 = new System.Windows.Forms.PictureBox();
            this.PlatformUp6 = new System.Windows.Forms.PictureBox();
            this.PlatformUp5 = new System.Windows.Forms.PictureBox();
            this.PlatformUp4 = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.Coin7 = new System.Windows.Forms.PictureBox();
            this.Coin6 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coin5 = new System.Windows.Forms.PictureBox();
            this.PlatformUp3 = new System.Windows.Forms.PictureBox();
            this.PlatformUp1 = new System.Windows.Forms.PictureBox();
            this.PlatformUp2 = new System.Windows.Forms.PictureBox();
            this.Uranus = new System.Windows.Forms.PictureBox();
            this.Saturn = new System.Windows.Forms.PictureBox();
            this.Neptune = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Mars = new System.Windows.Forms.PictureBox();
            this.Jupitar = new System.Windows.Forms.PictureBox();
            this.Earth = new System.Windows.Forms.PictureBox();
            this.Sun = new System.Windows.Forms.PictureBox();
            this.PlatformDown3 = new System.Windows.Forms.PictureBox();
            this.PlatformDown2 = new System.Windows.Forms.PictureBox();
            this.PlatformDown1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uranus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neptune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jupitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameScore
            // 
            this.GameScore.AutoSize = true;
            this.GameScore.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameScore.ForeColor = System.Drawing.Color.Black;
            this.GameScore.Location = new System.Drawing.Point(12, 9);
            this.GameScore.Name = "GameScore";
            this.GameScore.Size = new System.Drawing.Size(149, 29);
            this.GameScore.TabIndex = 34;
            this.GameScore.Tag = "gamescore";
            this.GameScore.Text = "Score: 0";
            this.GameScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tag = "gametimer";
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Background
            // 
            this.Background.Image = global::Classified_Mission.Properties.Resources.set5_background_stars_Blurred_Long;
            this.Background.Location = new System.Drawing.Point(0, -23);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(3212, 520);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Background.TabIndex = 35;
            this.Background.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Classified_Mission.Properties.Resources.p1_stand1;
            this.Player.Location = new System.Drawing.Point(266, 332);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(41, 48);
            this.Player.TabIndex = 33;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            // 
            // Key1
            // 
            this.Key1.Image = global::Classified_Mission.Properties.Resources.keyRed;
            this.Key1.Location = new System.Drawing.Point(708, 268);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(34, 38);
            this.Key1.TabIndex = 32;
            this.Key1.TabStop = false;
            this.Key1.Tag = "key1";
            // 
            // PlatformUp6
            // 
            this.PlatformUp6.Image = global::Classified_Mission.Properties.Resources.tileBlue_16;
            this.PlatformUp6.Location = new System.Drawing.Point(755, 314);
            this.PlatformUp6.Name = "PlatformUp6";
            this.PlatformUp6.Size = new System.Drawing.Size(77, 50);
            this.PlatformUp6.TabIndex = 31;
            this.PlatformUp6.TabStop = false;
            this.PlatformUp6.Tag = "Platform";
            // 
            // PlatformUp5
            // 
            this.PlatformUp5.Image = global::Classified_Mission.Properties.Resources.tileBlue_05;
            this.PlatformUp5.Location = new System.Drawing.Point(692, 314);
            this.PlatformUp5.Name = "PlatformUp5";
            this.PlatformUp5.Size = new System.Drawing.Size(64, 50);
            this.PlatformUp5.TabIndex = 30;
            this.PlatformUp5.TabStop = false;
            this.PlatformUp5.Tag = "Platform";
            // 
            // PlatformUp4
            // 
            this.PlatformUp4.Image = global::Classified_Mission.Properties.Resources.tileBlue_15;
            this.PlatformUp4.Location = new System.Drawing.Point(631, 314);
            this.PlatformUp4.Name = "PlatformUp4";
            this.PlatformUp4.Size = new System.Drawing.Size(62, 50);
            this.PlatformUp4.TabIndex = 29;
            this.PlatformUp4.TabStop = false;
            this.PlatformUp4.Tag = "Platform";
            // 
            // Door
            // 
            this.Door.Image = global::Classified_Mission.Properties.Resources.platformPack_tile048;
            this.Door.Location = new System.Drawing.Point(79, 207);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(65, 50);
            this.Door.TabIndex = 28;
            this.Door.TabStop = false;
            this.Door.Tag = "door1";
            // 
            // Coin7
            // 
            this.Coin7.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin7.Location = new System.Drawing.Point(460, 324);
            this.Coin7.Name = "Coin7";
            this.Coin7.Size = new System.Drawing.Size(27, 25);
            this.Coin7.TabIndex = 27;
            this.Coin7.TabStop = false;
            this.Coin7.Tag = "coin7";
            // 
            // Coin6
            // 
            this.Coin6.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin6.Location = new System.Drawing.Point(427, 324);
            this.Coin6.Name = "Coin6";
            this.Coin6.Size = new System.Drawing.Size(27, 25);
            this.Coin6.TabIndex = 27;
            this.Coin6.TabStop = false;
            this.Coin6.Tag = "coin6";
            // 
            // Coin1
            // 
            this.Coin1.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin1.Location = new System.Drawing.Point(379, 355);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(27, 25);
            this.Coin1.TabIndex = 27;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "coin1";
            // 
            // Coin2
            // 
            this.Coin2.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin2.Location = new System.Drawing.Point(412, 355);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(27, 25);
            this.Coin2.TabIndex = 27;
            this.Coin2.TabStop = false;
            this.Coin2.Tag = "coin2";
            // 
            // Coin3
            // 
            this.Coin3.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin3.Location = new System.Drawing.Point(445, 355);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(27, 25);
            this.Coin3.TabIndex = 27;
            this.Coin3.TabStop = false;
            this.Coin3.Tag = "coin3";
            // 
            // Coin4
            // 
            this.Coin4.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin4.Location = new System.Drawing.Point(478, 355);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(27, 25);
            this.Coin4.TabIndex = 27;
            this.Coin4.TabStop = false;
            this.Coin4.Tag = "coin4";
            // 
            // Coin5
            // 
            this.Coin5.Image = global::Classified_Mission.Properties.Resources.coin4;
            this.Coin5.Location = new System.Drawing.Point(511, 355);
            this.Coin5.Name = "Coin5";
            this.Coin5.Size = new System.Drawing.Size(27, 25);
            this.Coin5.TabIndex = 26;
            this.Coin5.TabStop = false;
            this.Coin5.Tag = "coin5";
            // 
            // PlatformUp3
            // 
            this.PlatformUp3.AccessibleName = "test";
            this.PlatformUp3.Image = global::Classified_Mission.Properties.Resources.tileBlue_25;
            this.PlatformUp3.Location = new System.Drawing.Point(142, 256);
            this.PlatformUp3.Name = "PlatformUp3";
            this.PlatformUp3.Size = new System.Drawing.Size(69, 50);
            this.PlatformUp3.TabIndex = 25;
            this.PlatformUp3.TabStop = false;
            this.PlatformUp3.Tag = "Platform";
            // 
            // PlatformUp1
            // 
            this.PlatformUp1.AccessibleName = "test";
            this.PlatformUp1.Image = global::Classified_Mission.Properties.Resources.tileBlue_24;
            this.PlatformUp1.Location = new System.Drawing.Point(18, 256);
            this.PlatformUp1.Name = "PlatformUp1";
            this.PlatformUp1.Size = new System.Drawing.Size(63, 50);
            this.PlatformUp1.TabIndex = 24;
            this.PlatformUp1.TabStop = false;
            this.PlatformUp1.Tag = "Platform";
            // 
            // PlatformUp2
            // 
            this.PlatformUp2.AccessibleName = "test";
            this.PlatformUp2.Image = global::Classified_Mission.Properties.Resources.tileBlue_05;
            this.PlatformUp2.Location = new System.Drawing.Point(80, 256);
            this.PlatformUp2.Name = "PlatformUp2";
            this.PlatformUp2.Size = new System.Drawing.Size(63, 50);
            this.PlatformUp2.TabIndex = 23;
            this.PlatformUp2.TabStop = false;
            this.PlatformUp2.Tag = "Platform";
            // 
            // Uranus
            // 
            this.Uranus.Image = global::Classified_Mission.Properties.Resources.Uranus;
            this.Uranus.Location = new System.Drawing.Point(3050, 46);
            this.Uranus.Name = "Uranus";
            this.Uranus.Size = new System.Drawing.Size(63, 59);
            this.Uranus.TabIndex = 22;
            this.Uranus.TabStop = false;
            this.Uranus.Tag = "uranus";
            // 
            // Saturn
            // 
            this.Saturn.Image = global::Classified_Mission.Properties.Resources.Saturn1;
            this.Saturn.Location = new System.Drawing.Point(2030, 203);
            this.Saturn.Name = "Saturn";
            this.Saturn.Size = new System.Drawing.Size(95, 73);
            this.Saturn.TabIndex = 21;
            this.Saturn.TabStop = false;
            this.Saturn.Tag = "saturn";
            // 
            // Neptune
            // 
            this.Neptune.Image = global::Classified_Mission.Properties.Resources.Pluto1;
            this.Neptune.Location = new System.Drawing.Point(2619, 155);
            this.Neptune.Name = "Neptune";
            this.Neptune.Size = new System.Drawing.Size(52, 50);
            this.Neptune.TabIndex = 20;
            this.Neptune.TabStop = false;
            this.Neptune.Tag = "neptune";
            // 
            // Moon
            // 
            this.Moon.Image = global::Classified_Mission.Properties.Resources.Moon1;
            this.Moon.Location = new System.Drawing.Point(847, 227);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(12, 12);
            this.Moon.TabIndex = 19;
            this.Moon.TabStop = false;
            this.Moon.Tag = "moon";
            // 
            // Mars
            // 
            this.Mars.Image = global::Classified_Mission.Properties.Resources.Mars1;
            this.Mars.Location = new System.Drawing.Point(1258, 282);
            this.Mars.Name = "Mars";
            this.Mars.Size = new System.Drawing.Size(47, 45);
            this.Mars.TabIndex = 18;
            this.Mars.TabStop = false;
            this.Mars.Tag = "mars";
            // 
            // Jupitar
            // 
            this.Jupitar.Image = global::Classified_Mission.Properties.Resources.Jupitar1;
            this.Jupitar.Location = new System.Drawing.Point(1623, 46);
            this.Jupitar.Name = "Jupitar";
            this.Jupitar.Size = new System.Drawing.Size(84, 81);
            this.Jupitar.TabIndex = 17;
            this.Jupitar.TabStop = false;
            this.Jupitar.Tag = "jupitar";
            // 
            // Earth
            // 
            this.Earth.Image = global::Classified_Mission.Properties.Resources.Earth1;
            this.Earth.Location = new System.Drawing.Point(794, 203);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(47, 45);
            this.Earth.TabIndex = 16;
            this.Earth.TabStop = false;
            this.Earth.Tag = "earth";
            // 
            // Sun
            // 
            this.Sun.Image = global::Classified_Mission.Properties.Resources.Sun1;
            this.Sun.Location = new System.Drawing.Point(254, 81);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(99, 98);
            this.Sun.TabIndex = 15;
            this.Sun.TabStop = false;
            this.Sun.Tag = "sun";
            // 
            // PlatformDown3
            // 
            this.PlatformDown3.Image = global::Classified_Mission.Properties.Resources.tileBlue_04;
            this.PlatformDown3.Location = new System.Drawing.Point(236, 400);
            this.PlatformDown3.Name = "PlatformDown3";
            this.PlatformDown3.Size = new System.Drawing.Size(48, 50);
            this.PlatformDown3.TabIndex = 14;
            this.PlatformDown3.TabStop = false;
            this.PlatformDown3.Tag = "Platform";
            // 
            // PlatformDown2
            // 
            this.PlatformDown2.Image = global::Classified_Mission.Properties.Resources.tileBlue_06;
            this.PlatformDown2.Location = new System.Drawing.Point(511, 400);
            this.PlatformDown2.Name = "PlatformDown2";
            this.PlatformDown2.Size = new System.Drawing.Size(64, 50);
            this.PlatformDown2.TabIndex = 13;
            this.PlatformDown2.TabStop = false;
            this.PlatformDown2.Tag = "Platform";
            this.PlatformDown2.Click += new System.EventHandler(this.PlatformDown2_Click);
            // 
            // PlatformDown1
            // 
            this.PlatformDown1.BackgroundImage = global::Classified_Mission.Properties.Resources.tileBlue_05;
            this.PlatformDown1.Image = global::Classified_Mission.Properties.Resources.tileBlue_05;
            this.PlatformDown1.Location = new System.Drawing.Point(279, 400);
            this.PlatformDown1.Name = "PlatformDown1";
            this.PlatformDown1.Size = new System.Drawing.Size(233, 50);
            this.PlatformDown1.TabIndex = 12;
            this.PlatformDown1.TabStop = false;
            this.PlatformDown1.Tag = "Platform";
            this.PlatformDown1.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 481);
            this.Controls.Add(this.GameScore);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Key1);
            this.Controls.Add(this.PlatformUp6);
            this.Controls.Add(this.PlatformUp5);
            this.Controls.Add(this.PlatformUp4);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Coin7);
            this.Controls.Add(this.Coin6);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin5);
            this.Controls.Add(this.PlatformUp3);
            this.Controls.Add(this.PlatformUp1);
            this.Controls.Add(this.PlatformUp2);
            this.Controls.Add(this.Uranus);
            this.Controls.Add(this.Saturn);
            this.Controls.Add(this.Neptune);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Mars);
            this.Controls.Add(this.Jupitar);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.PlatformDown3);
            this.Controls.Add(this.PlatformDown2);
            this.Controls.Add(this.PlatformDown1);
            this.Controls.Add(this.Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Classified Mission";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uranus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neptune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jupitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.PictureBox PlatformDown1;
		private System.Windows.Forms.PictureBox PlatformDown2;
		private System.Windows.Forms.PictureBox PlatformDown3;
		private System.Windows.Forms.PictureBox Sun;
		private System.Windows.Forms.PictureBox Earth;
		private System.Windows.Forms.PictureBox Jupitar;
		private System.Windows.Forms.PictureBox Mars;
		private System.Windows.Forms.PictureBox Moon;
		private System.Windows.Forms.PictureBox Neptune;
		private System.Windows.Forms.PictureBox Saturn;
		private System.Windows.Forms.PictureBox Uranus;
		private System.Windows.Forms.PictureBox PlatformUp2;
		private System.Windows.Forms.PictureBox PlatformUp1;
		private System.Windows.Forms.PictureBox PlatformUp3;
		private System.Windows.Forms.PictureBox Coin5;
		private System.Windows.Forms.PictureBox Coin4;
		private System.Windows.Forms.PictureBox Coin3;
		private System.Windows.Forms.PictureBox Coin2;
		private System.Windows.Forms.PictureBox Coin1;
		private System.Windows.Forms.PictureBox Coin6;
		private System.Windows.Forms.PictureBox Coin7;
		private System.Windows.Forms.PictureBox Door;
		private System.Windows.Forms.PictureBox PlatformUp4;
		private System.Windows.Forms.PictureBox PlatformUp5;
		private System.Windows.Forms.PictureBox PlatformUp6;
        private System.Windows.Forms.PictureBox Key1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label GameScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Background;
    }
}

