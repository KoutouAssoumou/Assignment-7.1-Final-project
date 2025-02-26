﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_7._1_Final_Project_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texte = textBoxenter.Text;
            if (comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.ToString() == "Admin")
            {
                

                if (Regex.IsMatch(texte, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
                {
                    MessageBox.Show("The User is an Admin.");
                }
                else
                {
                    MessageBox.Show("The Admin profile is composed of uppercase, lowercase and number letters. Please re-enter a username ");
                }
                
            }
            else
            {
                if (Regex.IsMatch(texte, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("The User is a simple User");
                }
                else
                {
                    MessageBox.Show("The Simple profile is composed of letters. Please re-enter a username");
                }
            }
        }
    }
}
