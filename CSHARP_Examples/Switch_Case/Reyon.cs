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
    public partial class Reyon : Form
    {
        public Reyon()
        {
            InitializeComponent();
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
          string reyon = txtReyon.Text;
            switch (reyon)
            {
                case"elma":
                case "armut":
                case "karpuz":
                    MessageBox.Show("Manav");
                    break;
                case "sucuk":
                case "salam":
                case "sosis":
                    MessageBox.Show("Şarküteri");
                    break;
                case "televizyon":
                case "telefon":
                case "bilgisayar":
                    MessageBox.Show("Teknoloji");
                    break;
            }
        }
    }
}
