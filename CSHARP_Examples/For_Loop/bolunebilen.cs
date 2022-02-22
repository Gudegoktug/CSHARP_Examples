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
    public partial class _3eBolunebilen : Form
    {
        public _3eBolunebilen()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
