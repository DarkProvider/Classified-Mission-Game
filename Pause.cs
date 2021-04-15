using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classified_Mission
{
    public partial class Pause : Form
    {
        
        public Pause()
        {
            InitializeComponent();
            ReadHighScore();

        }

        private void ReadHighScore()
        {
            // Generates a new txt file for the highscore if it doesn't exist already

            if (!File.Exists("classifiedhighscore.txt"))
            {

                TextWriter htw = new StreamWriter("classifiedhighscore.txt");
                htw.Write("0");
                htw.Close();
            }

            // Opens up the created txt file and reads it to put into its own variable

            TextReader htr = new StreamReader("classifiedhighscore.txt");

            GameScore.Text = htr.ReadLine();
            htr.Close();
        }

        public void reumebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//SpaceCadetLow.wav");
            splayer.PlayLooping();

        }

    }
}
