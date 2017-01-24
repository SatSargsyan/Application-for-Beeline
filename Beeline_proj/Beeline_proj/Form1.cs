using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beeline_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyClick += button990_Click;
            MyClick += button1500_Click;
            MyClick += button2500_Click_1;
            MyClick += button3500_Click;

            Control c1 = button990;
        }
        private event EventHandler myClick;
        public event EventHandler MyClick
        {
            add
            {
                myClick += value;
            }
            remove
            {
                myClick -= value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button990_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Button1 f1 = new Button1(); 
            f1.Show();

        }

        private void button1500_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Button2 f2 = new Button2();
            f2.Show();
        }
       
        private void button3500_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Button4 f4 = new Button4();
            f4.Show();
        }

        private void button2500_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Button3 f3 = new Button3();
            f3.Show();
        }

        private void button3500_Click_1(object sender, EventArgs e)
        {

        }
    }
}
