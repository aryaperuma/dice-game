using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_Dice_Pig_Game
{
    public partial class frmGameMenu : Form
    {
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void btnMenuStartGame_Click(object sender, EventArgs e)
        {
            frmTwoDicePig gameWindow = new frmTwoDicePig();

            gameWindow.Show();
        }

        private void btnMenuRules_Click(object sender, EventArgs e)
        {
            frmRules gameWindow = new frmRules();

            gameWindow.Show();
        }
    }
}
