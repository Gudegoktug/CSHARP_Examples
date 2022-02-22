using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.For_Loop
{
    public partial class AradakiSayilariToplama : Form
    {
        public AradakiSayilariToplama()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
           
            int toplam = 0;

            for (int i = 0; i < 100;i++)
            {
                toplam = toplam+ i;
            }
                label1.Text = (toplam.ToString());
        }
    }
}
