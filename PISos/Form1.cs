﻿using PISos.Db;
using PISos.UI;
using System;
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
        private DataProvider Db;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Authorization()
        {

        }

        public class Autorizatioh
        {
            public void Role(string login, string password)
            {

            }

        }

        private void btnLoginAnon_Click(object sender, EventArgs e)
        {
            AnonForm newForm = new AnonForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            UserInfo user = Db.GetUser(login, password);
            Session.User = user;
            if (user == null)
            {
                MessageBox.Show("Некорректная пара логинg/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //AnonForm newForm = new AnonForm();
                //this.Hide();
                //newForm.ShowDialog();
                //this.Show();
                //return;
            }

            if (user.Role == UserRoleType.User)
            {
                UserForm newForm = new UserForm();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                return;
            }

            if (user.Role == UserRoleType.Admin)
            {
                AdminForm newForm = new AdminForm();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Db = new DataProvider();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

