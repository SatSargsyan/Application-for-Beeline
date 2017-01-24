# Application-for-Beeline
<h3>There were using Forms, Events</h3>

For example 
```C# 
using System.Windows.Forms;

namespace Beeline_proj
{
    public partial class Button1 : Form
    {
        public Button1()
        {
            InitializeComponent();
        }

        private void Button1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://beeline.am/am/Catalog/Packages/Mobile-Packages/TP-Smart-/Prepaid-Smart/Smart-1500/p/ALL_1_P#");
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
```
For running the program.
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beeline_proj
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
                   Application.Run(new Form1());
        }
    }
}
```

![form1](https://cloud.githubusercontent.com/assets/20840005/22259987/e314b188-e280-11e6-9c00-7d0777621414.gif)
