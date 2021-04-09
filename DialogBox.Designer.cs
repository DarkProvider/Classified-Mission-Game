namespace Classified_Mission
{
    partial class DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            this.yesbutton = new System.Windows.Forms.Button();
            this.nopebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hintbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.White;
            this.yesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.yesbutton.Location = new System.Drawing.Point(561, 319);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(98, 32);
            this.yesbutton.TabIndex = 1;
            this.yesbutton.Tag = "yeah";
            this.yesbutton.Text = "Yes";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // nopebutton
            // 
            this.nopebutton.BackColor = System.Drawing.Color.White;
            this.nopebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.nopebutton.Location = new System.Drawing.Point(437, 319);
            this.nopebutton.Name = "nopebutton";
            this.nopebutton.Size = new System.Drawing.Size(98, 32);
            this.nopebutton.TabIndex = 2;
            this.nopebutton.Tag = "nope";
            this.nopebutton.Text = "Nope";
            this.nopebutton.UseVisualStyleBackColor = false;
            this.nopebutton.Click += new System.EventHandler(this.nopebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Over!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "I normally don\'t give second chances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "But do you wanna try again?";
            // 
            // hintbutton
            // 
            this.hintbutton.BackColor = System.Drawing.Color.White;
            this.hintbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.hintbutton.Location = new System.Drawing.Point(40, 319);
            this.hintbutton.Name = "hintbutton";
            this.hintbutton.Size = new System.Drawing.Size(98, 32);
            this.hintbutton.TabIndex = 6;
            this.hintbutton.Tag = "nope";
            this.hintbutton.Text = "Hint!?";
            this.hintbutton.UseVisualStyleBackColor = false;
            this.hintbutton.Click += new System.EventHandler(this.hintbutton_Click);
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.hintbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nopebutton);
            this.Controls.Add(this.yesbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogBox";
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.DialogBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Button nopebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hintbutton;
    }
}