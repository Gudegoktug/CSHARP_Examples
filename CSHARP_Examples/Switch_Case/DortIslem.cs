using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.Switch_Case
{
    public partial class DortIslem : Form
    {
        public DortIslem()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            string islem = txtIslem.Text;
            
            switch (islem)
            {
                case "+":
                    lblSonuc.Text=(sayi1+sayi2).ToString();
                    break;
                case "-":
                    lblSonuc.Text=(sayi1 -sayi2).ToString();
                    break;
                case "/":
                    lblSonuc.Text=(sayi1/sayi2).ToString();
                    break ;
                case "*":
                    lblSonuc.Text = (sayi1 * sayi2).ToString();
                    break;
                    default:
                    MessageBox.Show("Hatalı İşlem ..1!");
                    break;
            }
        }
    }
}
