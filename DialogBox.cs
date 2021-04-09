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
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            ClassifiedMissionGame.RestartGame();
            
        }


        private void nopebutton_Click(object sender, EventArgs e)
        {
            ClassifiedMissionGame.CloseGame();
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            ClassifiedMissionGame.CloseGame();
        }

        private void hintbutton_Click(object sender, EventArgs e)
        {
            Help helpbox = new Help();
            helpbox.Show();
        }
    }
}
