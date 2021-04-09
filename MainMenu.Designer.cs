namespace Classified_Mission
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.playbutton = new System.Windows.Forms.Label();
            this.aboutbutton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.AutoSize = true;
            this.playbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.playbutton.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.ForeColor = System.Drawing.Color.White;
            this.playbutton.Location = new System.Drawing.Point(814, 344);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(79, 33);
            this.playbutton.TabIndex = 2;
            this.playbutton.Text = "Play";
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // aboutbutton
            // 
            this.aboutbutton.AutoSize = true;
            this.aboutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.aboutbutton.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbutton.ForeColor = System.Drawing.Color.White;
            this.aboutbutton.Location = new System.Drawing.Point(805, 396);
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Size = new System.Drawing.Size(95, 33);
            this.aboutbutton.TabIndex = 3;
            this.aboutbutton.Text = "About";
            this.aboutbutton.Click += new System.EventHandler(this.aboutbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Highest score:";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.highscore.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.Color.White;
            this.highscore.Location = new System.Drawing.Point(459, 316);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(22, 23);
            this.highscore.TabIndex = 5;
            this.highscore.Tag = "gamehighscore";
            this.highscore.Text = "0";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.Copyright.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.Color.White;
            this.Copyright.Location = new System.Drawing.Point(333, 450);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(294, 14);
            this.Copyright.TabIndex = 6;
            this.Copyright.Tag = "Copyrighttag";
            this.Copyright.Text = "Copyrights reserved 2021 © Yazan Al Akkad";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Title.Image = global::Classified_Mission.Properties.Resources.Mission_Classified___No_background___250x;
            this.Title.Location = new System.Drawing.Point(351, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(250, 250);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Title.TabIndex = 1;
            this.Title.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(974, 474);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aboutbutton);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Classified Mission - Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Label playbutton;
        private System.Windows.Forms.Label aboutbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label Copyright;
    }
}