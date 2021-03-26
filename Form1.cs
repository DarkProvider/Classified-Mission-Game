using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classified_Mission
{
    public partial class ClassifiedMissionGame : Form
    {


		bool goLeft, goRight, jumping, hasGas;

		int jumpSpeed = 10;
		int force = 8;
		int score = 0;

		int playerSpeed = 10;
		int backgroundSpeed = 10;

        public ClassifiedMissionGame()
        {
            InitializeComponent();

			//This will mount the item to the backgeound to make it transparent

			//Platforms
			Background.Controls.Add(PlatformDown1);
			Background.Controls.Add(PlatformDown2);
			Background.Controls.Add(PlatformDown3);
			Background.Controls.Add(PlatformDown4);
			Background.Controls.Add(PlatformDown5);
			Background.Controls.Add(PlatformDown6);
			Background.Controls.Add(PlatformUp1);
			Background.Controls.Add(PlatformUp2);
			Background.Controls.Add(PlatformUp3);
			Background.Controls.Add(PlatformUp4);
			Background.Controls.Add(PlatformUp5);
			Background.Controls.Add(PlatformUp6);



			//Planets
			Background.Controls.Add(Sun);
			Background.Controls.Add(Earth);
			Background.Controls.Add(Moon);
			Background.Controls.Add(Mars);
			Background.Controls.Add(Jupitar);
			Background.Controls.Add(Saturn);
			Background.Controls.Add(Neptune);
			Background.Controls.Add(Uranus);

			//Coins
			//Background.Controls.Add(Coin1);
			Background.Controls.Add(Coin2);
			Background.Controls.Add(Coin3);
			Background.Controls.Add(Coin4);
			Background.Controls.Add(Coin5);
			Background.Controls.Add(Coin6);
			Background.Controls.Add(Coin7);


			//Other Objects
			Background.Controls.Add(DoorL1);
			Background.Controls.Add(Ship); 
			//Background.Controls.Add(Key1);
			//Background.Controls.Add(Player);



			//This will place the objects and change the color of the background to transparent relatively to the parent background it is located in

			//Platforms
			PlatformDown1.BackColor = Color.Transparent;
			PlatformDown1.Location = new Point(283, 399);
			PlatformDown2.BackColor = Color.Transparent;
			PlatformDown2.Location = new Point(516, 399);
			PlatformDown3.BackColor = Color.Transparent;
			PlatformDown3.Location = new Point(240, 399);
			PlatformDown4.BackColor = Color.Transparent;
			PlatformDown4.Location = new Point(2767, 383);
			PlatformDown5.BackColor = Color.Transparent;
			PlatformDown5.Location = new Point(2810, 383);
			PlatformDown6.BackColor = Color.Transparent;
			PlatformDown6.Location = new Point(3043, 383);
			PlatformUp1.BackColor = Color.Transparent;
			PlatformUp1.Location = new Point(17, 256);
			PlatformUp2.BackColor = Color.Transparent;
			PlatformUp2.Location = new Point(80, 256);
			PlatformUp3.BackColor = Color.Transparent;
			PlatformUp3.Location = new Point(143, 256);
			PlatformUp4.BackColor = Color.Transparent;
			PlatformUp4.Location = new Point(631, 314);
			PlatformUp5.BackColor = Color.Transparent;
			PlatformUp5.Location = new Point(693, 314);
			PlatformUp6.BackColor = Color.Transparent;
			PlatformUp6.Location = new Point(736, 314);

			//Planets
			Sun.BackColor = Color.Transparent;
			Sun.Location = new Point(254, 81);
			Earth.BackColor = Color.Transparent;
			Earth.Location = new Point(794, 203);
			Moon.BackColor = Color.Transparent;
			Moon.Location = new Point(847, 227);
			Mars.BackColor = Color.Transparent;
			Mars.Location = new Point(1258, 282);
			Jupitar.BackColor = Color.Transparent;
			Jupitar.Location = new Point(1623, 46);
			Saturn.BackColor = Color.Transparent;
			Saturn.Location = new Point(2030, 203);
			Neptune.BackColor = Color.Transparent;
			Neptune.Location = new Point(2619, 155);
			Uranus.BackColor = Color.Transparent;
			Uranus.Location = new Point(3050, 46);

			//Coins
			Coin1.BackColor = Color.Transparent;
			Coin1.Location = new Point(379, 355);
			Coin2.BackColor = Color.Transparent;
			Coin2.Location = new Point(412, 355);
			Coin3.BackColor = Color.Transparent;
			Coin3.Location = new Point(445, 355);
			Coin4.BackColor = Color.Transparent;
			Coin4.Location = new Point(478, 355);
			Coin5.BackColor = Color.Transparent;
			Coin5.Location = new Point(511, 355);
			Coin6.BackColor = Color.Transparent;
			Coin6.Location = new Point(427, 324);
			Coin7.BackColor = Color.Transparent;
			Coin7.Location = new Point(460, 324);

			//Other Objects
			DoorL1.BackColor = Color.Transparent;
			DoorL1.Location = new Point(79, 207);
			Gas.BackColor = Color.Transparent;
			Gas.Location = new Point(708, 275);
			Ship.BackColor = Color.Transparent;
			Ship.Location = new Point(2901, 329);

			//Player.BackColor = Color.Transparent;
			//Player.Location = new Point(254, 355);

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void Back1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{

		}

		private void PlatformDown2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void MainTimerEvent(object sender, EventArgs e)
		{
			GameScore.Text = "Score: " + score;
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

			if (goRight == true && Background.Left > -2409) 
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
				string LockGreenTop = PictureBox.picture;
				switch (LockGreenTop)
				{

					case (Player.Bounds.IntersectsWith(Ship.Bounds) && hasGas == true):
						UpdatePictureBox(@"[Images1 Path]");
						break;

				}


				if (x is PictureBox && (string)x.Tag == "player")
				{ 
				


				}

				if (x is PictureBox && (string)x.Tag == "doorl2")
				{
					x.Visible = false;
				}
				if (x is PictureBox && (string)x.Tag == "shipl2")
				{
					x.Visible = false;
				}

				if (x is PictureBox && (string)x.Tag == "Platform_l2") 
				{

					if (x is PictureBox && (string)x.Tag == "Platform_l2" ) 
					{
						x.Visible = false;
					}


					if (Player.Bounds.IntersectsWith(x.Bounds) && jumping == false) 
					
					{

						force = 8;
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
						score += 1;

					}
				
				}
			}

			if (Player.Bounds.IntersectsWith(Gas.Bounds)) 
			{

				Gas.Visible = false;
				hasGas = true;

			}

			if (Player.Bounds.IntersectsWith(Ship.Bounds) && hasGas == true)
			{


				Player.Visible = false;
				GameTimer.Stop();
				MessageBox.Show("Well done, you made it to the ship with a full gas tank!" + Environment.NewLine + Environment.NewLine + "You wanna play again?");
				Ship.Visible = false;
				RestartGame();

			}
			else if (Player.Bounds.IntersectsWith(Ship.Bounds) && hasGas == false)
			{

				MessageBox.Show("You will need gas to power on the ship!" + Environment.NewLine + Environment.NewLine + "Go back and get the gas ffs!!!");

			}

			if (Player.Top + Player.Height > this.ClientSize.Height) 
			{

				GameTimer.Stop();
				MessageBox.Show("You fell into the void which means you died, you should've known that before doing it!" + Environment.NewLine + Environment.NewLine + "I don't normally give second chances, but do you wanna try again?");
				RestartGame();

			}
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
		}

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{

		}

		private void PlatformDown4_Click(object sender, EventArgs e)
		{

		}

		private void PlatformDown5_Click(object sender, EventArgs e)
		{

		}

		private void PlatformDown6_Click(object sender, EventArgs e)
		{

		}

		private void CloseGame(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void RestartGame() 
		{

			ClassifiedMissionGame newWindow = new ClassifiedMissionGame();
			newWindow.Show();
			this.Hide();

		}

		private void MoveGameElements(string direction) 
		{ 

			foreach (Control x in this.Controls) 
			{

				if (x is PictureBox && (string)x.Tag == "Platform_l2" || x is PictureBox && (string)x.Tag == "Coin" || x is PictureBox && (string)x.Tag == "key1" || x is PictureBox && (string)x.Tag == "door1_l1") 
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
