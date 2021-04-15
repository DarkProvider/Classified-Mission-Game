using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classified_Mission
{
    public partial class Level3Mars : Form
    {

		bool goLeft, goRight, isGameOver, jumping, hasRes;

		int jumpSpeed = 4;
		int force = 1;
		int score = 0;
		int gamehighscore = 0;

		// Speeds
		int playerSpeed = 10;
		int backgroundSpeed = 35;

		// Health
		int playerhealth = 100;


		Random randNum = new Random();

		// Enemies
		int enemy1Speed = 1;
		int enemy2Speed = 1;
		int enemy3Speed = 1;

		//Collectables
		int medkit = 0;
		int shield = 0;

		public Level3Mars()
        {
			InitializeComponent();
			ReadHighScore();
			Player.Visible = true;
			Station.Visible = true;

			SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//SpaceCadetLow.wav");
			splayer.PlayLooping();



			//Player & enemy positions
			Player.Left = 88;
			Player.Top = 207;
			///
			enemy1.Left = 464;
			enemy1.Top = 330;
			enemy2.Left = 1629;
			enemy2.Top = 354;
			enemy3.Left = 2063;
			enemy3.Top = 267;
			///

			// Other objects
			DoorL2.Left = 79;
			DoorL2.Top = 197;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ReadHighScore();

		}




		// Highscore properties

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

		public void WriteHighScore()
		{

			// Creates a writer and saves the file (Overwrites the highscore if score is equal or greater than the actual score)

			if (score >= Convert.ToInt32(highscore.Text))
			{

				TextWriter htw = new StreamWriter("classifiedhighscore.txt");
				htw.WriteLine(score);
				htw.Close();


			}
		}



		private void Back1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		public void GameOver()
		{



			SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//fall.wav");
			splayer.Play();
			GameTimer.Stop();
			DialogBox gameover = new DialogBox();
			gameover.Show();


		}

		public void UpdateHighScore()
		{

			WriteHighScore();
			ReadHighScore();


		}

		private void MainTimerEvent(object sender, EventArgs e)
		{




			GameScore.Text = "Score: " + score;
			//highscore.Text = "High Score: " + gamehighscore;
			medkitcollected.Text = "Medkits: " + medkit;
			shieldcollected.Text = "Shields: " + shield;
			Player.Top += jumpSpeed;




			if (goLeft == true && Player.Left > 3)
			{
				Player.Left -= playerSpeed;
			}
			if (goRight == true && Player.Left + (Player.Width + 20) < this.ClientSize.Width)
			{
				Player.Left += playerSpeed;
			}


			if (goLeft == true && Background.Left < 0)
			{
				Background.Left += backgroundSpeed;
				MoveGameElements("forward");
			}

			if (goRight == true && Background.Left > -2200)
			{
				Background.Left -= backgroundSpeed;
				MoveGameElements("backward");
			}

			if (jumping == true)
			{
				jumpSpeed = -15;
				force -= 1;
			}
			else
			{
				jumpSpeed = 15;
			}

			if (jumping == true && force < 0)
			{
				jumping = false;
			}

			foreach (Control x in this.Controls)
			{

				if (x is PictureBox && (string)x.Tag == "medkit")
				{

					if (Player.Bounds.IntersectsWith(x.Bounds))
					{

						this.Controls.Remove(x);
						((PictureBox)x).Dispose();
						medkit += 1;
						playerhealth = 100;


					}

				}

				if (x is PictureBox && (string)x.Tag == "shield")
				{

					if (Player.Bounds.IntersectsWith(x.Bounds))
					{

						this.Controls.Remove(x);
						((PictureBox)x).Dispose();
						shield += 1;




					}

				}

				if (x is PictureBox && (string)x.Tag == "spiketraps")
				{


					if (Player.Bounds.IntersectsWith(x.Bounds))
					{

						playerhealth -= 20;

					}
				}
			}



			foreach (Control x in this.Controls)
			{



				if (x is PictureBox && (string)x.Tag == "Platform_l2")
				{


					if (Player.Bounds.IntersectsWith(x.Bounds) && jumping == false)

					{

						force = 6;
						Player.Top = x.Top - Player.Height;
						jumpSpeed = 0;

					}

					x.BringToFront();

				}

				if (x is PictureBox && (string)x.Tag == "Coin")
				{


					if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
					{

						x.Visible = false;
						//SoundPlayer splayer1 = new SoundPlayer(System.Environment.CurrentDirectory + "//coincollect.wav");
						//splayer1.Play();

						score += 1;

						UpdateHighScore();


					}

				}

				if ((string)x.Tag == "enemy")
				{

					if (Player.Bounds.IntersectsWith(x.Bounds))
					{

						GameOver();

					}

				}


				// Enemy Movements

				enemy1.Left -= enemy1Speed;

				if (enemy1.Left < PlatformDown2_l2.Left || enemy1.Left + enemy1.Width > PlatformDown2_l2.Left + PlatformDown2_l2.Width)
				{

					enemy1Speed = -enemy1Speed;


				}

				enemy2.Left += enemy2Speed;

				if (enemy2.Left < PlatformDown11_l2.Left || enemy2.Left + enemy2.Width > PlatformDown11_l2.Left + PlatformDown11_l2.Width)
				{

					enemy2Speed = -enemy2Speed;


				}

				enemy3.Left -= enemy3Speed;

				if (enemy3.Left < PlatformDown14_l2.Left || enemy3.Left + enemy3.Width > PlatformDown14_l2.Left + PlatformDown14_l2.Width)
				{

					enemy3Speed = -enemy3Speed;


				}


			}

			// Gas collecting
			if (Player.Bounds.IntersectsWith(Res.Bounds))
			{

				Res.Visible = false;
				hasRes = true;

			}

			if (Player.Bounds.IntersectsWith(Station.Bounds) && hasRes == true)
			{


				Player.Visible = false;
				Station.Visible = false;
				GameTimer.Stop();
				YouWin win = new YouWin();
				win.Show();
				

			}

			if (Player.Top + Player.Height > this.ClientSize.Height)
			{
				GameOver();
			}

			// Health section
			if (playerhealth > 1)
			{
				healthbar.Value = playerhealth;

			}
			else
			{
				isGameOver = true;
				GameOver();
			}

			//

		}



		private void KeyIsDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
			{
				goLeft = true;
			}
			if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
			{
				goRight = true;
			}
			if (e.KeyCode == Keys.Space && jumping == false)
			{
				jumping = true;
			}
			if (isGameOver == true)
			{

				return;

			}

		}

		private void KeyIsUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
			{
				goLeft = false;
			}
			if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
			{
				goRight = false;
			}
			if (e.KeyCode == Keys.Space && jumping == true)
			{
				jumping = false;
			}
			if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.P)
			{
				PauseGame();
			}
			if (e.KeyCode == Keys.C && medkit > 0)
			{
				medkit--;
				//UseMedkit();
				playerhealth = 100;

				if (medkit < 1)
				{

					MedkitC();

				}


			}
			if (e.KeyCode == Keys.V && shield > 0)
			{
				shield--;
				//UseShield();
				playerhealth += 200;

				if (shield < 1)
				{

					ShieldC();

				}


			}
		}

		private void CloseGame(object sender, FormClosedEventArgs e)
		{
			WriteHighScore();
			Application.Exit();
		}


		internal static void RestartGame()
		{
			try
			{
				Process.Start(System.Environment.CurrentDirectory + "//Classified Mission.exe");
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception EX)
			{

				MessageBox.Show("Uh oh, something happened!" + EX);
			}

			//Background theme
			SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//SpaceCadetLow.wav");
			splayer.PlayLooping();


		}

		public void PauseGame()
		{

			SoundPlayer splayer = new SoundPlayer(System.Environment.CurrentDirectory + "//SpaceCadetLow.wav");
			splayer.Stop();

			Pause pausemenu = new Pause();
			pausemenu.Show();

		}

		internal static void CloseGame()
		{
			try
			{
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception EX)
			{

				MessageBox.Show("Uh oh, something happened!" + EX);

			}
		}


		//Collectables

		private void MedkitC()
		{

			PictureBox medkit = new PictureBox();
			medkit.Image = Properties.Resources.Medkit1;
			medkit.SizeMode = PictureBoxSizeMode.AutoSize;
			medkit.BackColor = ColorTranslator.FromHtml("#131626");
			medkit.Left = randNum.Next(10, this.ClientSize.Width - medkit.Width);
			medkit.Top = randNum.Next(30, this.ClientSize.Height - medkit.Height);
			medkit.Tag = "medkit";
			this.Controls.Add(medkit);
			medkit.BringToFront();
			Player.BringToFront();

		}

		private void ShieldC()
		{

			PictureBox shield = new PictureBox();
			shield.Image = Properties.Resources.shield;
			shield.SizeMode = PictureBoxSizeMode.AutoSize;
			shield.BackColor = ColorTranslator.FromHtml("#131626");
			shield.Left = randNum.Next(10, this.ClientSize.Width - shield.Width);
			shield.Top = randNum.Next(30, this.ClientSize.Height - shield.Height);
			shield.Tag = "shield";
			this.Controls.Add(shield);
			shield.BringToFront();
			Player.BringToFront();

		}

		private void MoveGameElements(string direction)
		{

			foreach (Control x in this.Controls)
			{

				if (x is PictureBox && (string)x.Tag == "Platform_l2" || x is PictureBox && (string)x.Tag == "Coin" || x is PictureBox && (string)x.Tag == "gas" || x is PictureBox && (string)x.Tag == "Station" || x is PictureBox && (string)x.Tag == "enemy" || x is Label && (string)x.Tag == "floating" || x is PictureBox && (string)x.Tag == "doorl2" || x is PictureBox && (string)x.Tag == "shieldcollecttag" || x is PictureBox && (string)x.Tag == "medkitcollecttag" || x is PictureBox && (string)x.Tag == "speedcollecttag" || x is PictureBox && (string)x.Tag == "spiketraps" || x is PictureBox && (string)x.Tag == "medkit" || x is PictureBox && (string)x.Tag == "speed" || x is PictureBox && (string)x.Tag == "shield")
				{


					if (direction == "backward")
					{

						x.Left -= backgroundSpeed;

					}
					if (direction == "forward")
					{

						x.Left += backgroundSpeed;

					}

				}

			}
		}
    }
}
