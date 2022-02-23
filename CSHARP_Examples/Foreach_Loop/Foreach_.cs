using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples.Foreach
{
    public partial class Foreach_ : Form
    {
        public Foreach_()
        {
            InitializeComponent();
        }
        public static List<string> name = new List<string>();
        private void btnShow_Click(object sender, EventArgs e)
        {
            
        name.Add("mustafa");
        name.Add("melis");
        name.Add("beyza");
        name.Add("mehmet");
        name.Add("ayşe");
            foreach (string name in name)
            {
                listBox1.Items.Add(name);
            }
        }
    }
}
