namespace Classified_Mission
{
    partial class Pause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pause));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reumebutton = new System.Windows.Forms.Button();
            this.GameScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Your current highest score is:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(103, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 117);
            this.label1.TabIndex = 15;
            this.label1.Text = "Game Paused";
            // 
            // reumebutton
            // 
            this.reumebutton.BackColor = System.Drawing.Color.White;
            this.reumebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.reumebutton.Location = new System.Drawing.Point(284, 335);
            this.reumebutton.Name = "reumebutton";
            this.reumebutton.Size = new System.Drawing.Size(202, 38);
            this.reumebutton.TabIndex = 14;
            this.reumebutton.Tag = "nope";
            this.reumebutton.Text = "Resume Playing";
            this.reumebutton.UseVisualStyleBackColor = false;
            this.reumebutton.Click += new System.EventHandler(this.reumebutton_Click);
            // 
            // GameScore
            // 
            this.GameScore.AutoSize = true;
            this.GameScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.GameScore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameScore.ForeColor = System.Drawing.Color.White;
            this.GameScore.Location = new System.Drawing.Point(372, 276);
            this.GameScore.Name = "GameScore";
            this.GameScore.Size = new System.Drawing.Size(23, 26);
            this.GameScore.TabIndex = 18;
            this.GameScore.Text = "0";
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reumebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pause";
            this.Text = "Classified Mission - Game Paused";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reumebutton;
        private System.Windows.Forms.Label GameScore;
    }
}