using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.Dice_Game
{
    public partial class Simple_Dice_Game : Form
    {
        public Simple_Dice_Game()
        {
            InitializeComponent();
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computer = random.Next(1,7);
            lblComputer.Text = computer.ToString();
            int you = random.Next(1,7);
            lblSayi.Text = you.ToString();
            if (you>computer)
            {
                MessageBox.Show("you win bruhh.!11!");
            }
            else if(you<computer)
            {
                MessageBox.Show("loser");
            }
            else
            {
                MessageBox.Show("Draw...");
            }
        }
    }
}
