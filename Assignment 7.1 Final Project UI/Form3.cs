using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7._1_Final_Project_UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //open window form1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //open window form2
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
