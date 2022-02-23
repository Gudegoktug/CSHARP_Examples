using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.Try_Catch
{
    public partial class Toplama : Form
    {
        public Toplama()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = int.Parse(txtSayi1.Text);
                int sayi2 = int.Parse(txtSayi2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show($"Sayıların Toplamı: {toplam}");
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Sayı giriniz");
            }
            
        }
    }
}
