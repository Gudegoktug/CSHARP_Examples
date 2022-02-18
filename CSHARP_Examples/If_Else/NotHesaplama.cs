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
    public partial class NotHesaplama : Form
    {
        public NotHesaplama()
        {
            InitializeComponent();
        }
        double vize, final, ort;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize = double.Parse(txtVize.Text);
            final = double.Parse(txtFinal.Text);
            ort = ((vize * 30/100) + (final*70/100));
            if (ort >0 && ort<40)
            {
                lblort.Text = $"{ort} FF ile kaldın";
            }
            else if (ort >=40 && ort < 60)
            {
                lblort.Text = $"{ort} CC ile geçtin";
            }
            else if (ort >=60 && ort < 80)
            {
                lblort.Text = $"{ort} BB ile geçtin";
            }
            else if (ort >= 80 && ort <= 100)
            {
                lblort.Text = $"{ort} AA ile geçtin";
            }
            else
            {
                lblort.Text = "Hatalı sayı girdin";
            }
        }
    }
}
