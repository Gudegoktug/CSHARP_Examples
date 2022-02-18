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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        string user, password;
        private void button1_Click(object sender, EventArgs e)
        {
            user = "admin";
            password = "admin";
            if (user == txtKullaniciAdi.Text && password == txtSifre.Text)
            {
                MessageBox.Show("Başarılı Giriş");
            }
            else
            {
                MessageBox.Show("Kullanıcı veya Adınız yanlış");
            }
        }
    }
}
