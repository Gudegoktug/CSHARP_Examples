using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.If_Else
{
    public partial class BuyukSayiBulma : Form
    {
        public BuyukSayiBulma()
        {
            InitializeComponent();
        }

        int sayi1, sayi2, sayi3;
        int enBuyuk= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sayi3 = int.Parse(txtSayi3.Text);
            if (sayi1 > enBuyuk)
            {
                enBuyuk = sayi1;
            }
            if (sayi2 > enBuyuk)
            {
                enBuyuk = sayi2;
            }
            if (sayi3 > enBuyuk)
            {
                enBuyuk = sayi3;
            }
            MessageBox.Show($"En buyuk {enBuyuk}");
        }
    }
}
