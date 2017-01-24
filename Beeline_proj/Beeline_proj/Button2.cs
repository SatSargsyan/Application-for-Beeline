using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Beeline_proj
{
    public partial class Button2 : Form
    {
        public Button2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://beeline.am/am/Catalog/Packages/Mobile-Packages/TP-Smart-/Prepaid-Smart/Smart-2500/p/ALL_2_P");
            Process.Start(sInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
