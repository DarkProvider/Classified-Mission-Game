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
        public Form1()
        {
            InitializeComponent();

			//This will mount the item to the backgeound to make it transparent

			//Platforms
			Background.Controls.Add(PlatformDown2);
			Background.Controls.Add(PlatformDown3);
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
			Background2.Controls.Add(Jupitar);
			Background2.Controls.Add(Saturn);
			Background2.Controls.Add(Neptune);
			Background3.Controls.Add(Uranus);

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



			//This will place the objects and change the color of the background to transparent relatively to the parent background it is located in

			//Platforms
			PlatformDown2.BackColor = Color.Transparent;
			PlatformDown2.Location = new Point(516, 409);
			PlatformDown3.BackColor = Color.Transparent;
			PlatformDown3.Location = new Point(240, 409);
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
			Jupitar.Location = new Point(254, 81);
			Saturn.BackColor = Color.Transparent;
			Saturn.Location = new Point(794, 203);
			Neptune.BackColor = Color.Transparent;
			Neptune.Location = new Point(1258, 286);
			Uranus.BackColor = Color.Transparent;
			Uranus.Location = new Point(160, 90);

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
	}
}
