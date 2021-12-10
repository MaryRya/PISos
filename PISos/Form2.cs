using PISos.Db;
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
    public partial class UserForm : Form
    {
        private DataProvider Db;
        private long id;
        public UserForm()
        {
            InitializeComponent();           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.ShowDialog();
        }

        public void ShowDialog(long userId)
        {
            id = userId;
            this.ShowDialog();
        }

        public void Home_Load(object sender, EventArgs e)
        {
            Db = new DataProvider();
            petInfoBindingSource.DataSource = Db.GetLostPets();
            petInfo2BindingSource.DataSource = Db.GetFindPets();
            myPetBindingSource.DataSource = Db.GetMyPets(id);
            petInfoBindingSource1.DataSource = Db.GetMyAdsLost(id);
            petInfo2BindingSource1.DataSource = Db.GetMyAdsFind(id);

        }

        private void Import()
        {

        }

        private void AddAd()
        {

        }

        private void OpenCard()
        {

        }

        private void ChangeAd()
        {

        }

        private void RemoveAd()
        {
        }

        public class Ad
        {

            public void Look(string petgender, int idphoto, int data, string locality, string petcathegory, string discription, int phone)
            {
                
            }

            public static Register AddAd(string petgender, int idphoto, int data, string locality, string petcathegory, string discription, int phone)
            {
                return new Register();
            }

            public static Register Change()
            {
                return new Register();
            }

            public static Register Delete()
            {
                return new Register();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PetCard f2 = new PetCard();
            f2.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var city = comboBox5.Text;
            var category = comboBox7.Text;
            var data = dateTimePicker2.Value.Date;
            petInfo2BindingSource.DataSource = Db.FiltrforFind2(city, category, data);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var city = comboBox6.Text;
            var category = comboBox2.Text;
            var data = dateTimePicker1.Value.Date;
            petInfoBindingSource.DataSource = Db.FiltrforFind1(city, category, data);          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox6.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = new DateTime(1900, 01, 01);
            dateTimePicker1.CustomFormat = "01.01.1900";
            petInfoBindingSource.DataSource = Db.GetLostPets();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox5.Text = "";
            comboBox7.Text = "";
            dateTimePicker2.Value = new DateTime(1900, 01, 01);
            dateTimePicker2.CustomFormat = "01.01.1900";
            petInfo2BindingSource.DataSource = Db.GetFindPets();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var city = comboBox3.Text;
            var category = comboBox9.Text;
            var data = dateTimePicker4.Value.Date;
            petInfo2BindingSource1.DataSource = Db.FiltrforMyAds1(id, city, category, data);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.CustomFormat = "dd.MM.yyyy";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox9.Text = "";
            dateTimePicker4.Value = new DateTime(1900, 01, 01);
            dateTimePicker4.CustomFormat = "01.01.1900";
            petInfo2BindingSource1.DataSource = Db.GetMyAdsFind(id);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var city = comboBox4.Text;
            var category = comboBox10.Text;
            var data = dateTimePicker5.Value.Date;
            petInfo2BindingSource1.DataSource = Db.FiltrforMyAds1(id, city, category, data);
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.CustomFormat = "dd.MM.yyyy";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            comboBox4.Text = "";
            comboBox10.Text = "";
            dateTimePicker5.Value = new DateTime(1900, 01, 01);
            dateTimePicker5.CustomFormat = "01.01.1900";
            petInfo2BindingSource1.DataSource = Db.GetMyAdsLost(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var city = comboBox1.Text;
            var category = comboBox8.Text;
            var data = dateTimePicker3.Value.Date;
            myPetBindingSource.DataSource = Db.FiltrforMyPets(id, city, category, data);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd.MM.yyyy";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox8.Text = "";
            dateTimePicker3.Value = new DateTime(1900, 01, 01);
            dateTimePicker3.CustomFormat = "01.01.1900";
            myPetBindingSource.DataSource = Db.GetMyPets(id);
        }
    }
}
