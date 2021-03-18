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
    public partial class Form1 : Form
    {


		bool goLeft, goRight, jumping, hasKey;

		int jumpSpeed = 10;
		int force = 8;
		int score = 0;

		int playerSpeed = 10;
		int backgroundSpeed = 10;

        public Form1()
        {
            InitializeComponent();

			//This will mount the item to the backgeound to make it transparent

			//Platforms
			//Background.Controls.Add(PlatformDown1);
			//Background.Controls.Add(PlatformDown2);
			//Background.Controls.Add(PlatformDown3);
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
			Background.Controls.Add(Coin1);
			Background.Controls.Add(Coin2);
			Background.Controls.Add(Coin3);
			Background.Controls.Add(Coin4);
			Background.Controls.Add(Coin5);
			Background.Controls.Add(Coin6);
			Background.Controls.Add(Coin7);


			//Other Objects
			Background.Controls.Add(Door);
			Background.Controls.Add(Key1);
			//Background.Controls.Add(Player);



			//This will place the objects and change the color of the background to transparent relatively to the parent background it is located in

			//Platforms
			PlatformDown1.BackColor = Color.Transparent;
			PlatformDown1.Location = new Point(283, 399);
			PlatformDown2.BackColor = Color.Transparent;
			PlatformDown2.Location = new Point(516, 399);
			PlatformDown3.BackColor = Color.Transparent;
			PlatformDown3.Location = new Point(240, 399);
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
			Door.BackColor = Color.Transparent;
			Door.Location = new Point(79, 207);
			Key1.BackColor = Color.Transparent;
			Key1.Location = new Point(708, 275);
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
			}

			if (goRight == true && Background.Left > -2409) 
			{
				Background.Left -= backgroundSpeed;
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
				if (x is PictureBox && (string)x.Tag == "Platform") 
				{

					if (Player.Bounds.IntersectsWith(x.Bounds) && jumping == false) 
					
					{

						force = 8;
						Player.Top = x.Top - Player.Height;
						jumpSpeed = 0;
					
					}

					x.BringToFront();
				
				}
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

		private void CloseGame(object sender, FormClosedEventArgs e)
		{

		}

		private void RestartGame() 
		{ 
		
		}

		private void MoveGameElements(string direction) 
		{ 
		
		}
	}
}
