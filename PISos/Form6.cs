using System;
using PISos.Db;
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
    public partial class AdminForm : Form
    {

        private DataProvider Db;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Db = new DataProvider();
            petInfoBindingSource.DataSource = Db.GetLostPets();
            petInfo2BindingSource.DataSource = Db.GetFindPets();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var city = comboBox6.Text;
            var category = comboBox1.Text;
            var data = dateTimePicker1.Value.Date;
            petInfoBindingSource.DataSource = Db.FiltrforFind1(city, category, data);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox6.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = new DateTime(1900, 01, 01);
            dateTimePicker1.CustomFormat = "01.01.1900";
            petInfoBindingSource.DataSource = Db.GetLostPets();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var city = comboBox5.Text;
            var category = comboBox2.Text;
            var data = dateTimePicker2.Value.Date;
            petInfo2BindingSource.DataSource = Db.FiltrforFind2(city, category, data);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox5.Text = "";
            comboBox2.Text = "";
            dateTimePicker2.Value = new DateTime(1900, 01, 01);
            dateTimePicker2.CustomFormat = "01.01.1900";
            petInfo2BindingSource.DataSource = Db.GetFindPets();
        }
    }
}
