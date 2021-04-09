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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            ReadHighScore(); // This will intialize the read function of the highest scored points/collected coins

            SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//GameoverLow.wav");
            splayer.PlayLooping();
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

            highscore.Text = htr.ReadLine();
            htr.Close();
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            Help helpmenu = new Help();
            helpmenu.Show();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ClassifiedMissionGame = new ClassifiedMissionGame();
            ClassifiedMissionGame.Closed += (s, args) => this.Close();
            ClassifiedMissionGame.Show();
           
        }
    }
}
