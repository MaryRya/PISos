﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISos
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Authorization()
        {
            
        }
    }
}
