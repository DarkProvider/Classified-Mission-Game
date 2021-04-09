using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class DialogFall : Form
    {
        public DialogFall()
        {
            InitializeComponent();

            Tryagain.Text = "It seems that you have fallen into the void, I mean; you should've known better before doing it" +  Environment.NewLine + Environment.NewLine + "I normally don't give second chances but how about you try again? Be careful this time...." + Environment.NewLine + Environment.NewLine + "Try Again?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameScore_Click(object sender, EventArgs e)
        {

        }
    }
}
