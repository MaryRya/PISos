using PISos.Db;
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
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PetCard f2 = new PetCard();
            f2.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Db = new DataProvider();
            petInfoBindingSource.DataSource = Db.GetLostPets();
            petInfo2BindingSource.DataSource = Db.GetFindPets();
            myPetBindingSource.DataSource = Db.GetMyPets();
        }

        private void Filtr()
        {

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

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class Ad
        {

            public void Look(string petgender, int idphoto, int data, string locality, string petcathegory, string discription, int phone)
            {
                
            }
            public void LookMy()
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

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PetCard f2 = new PetCard();
            f2.ShowDialog();
        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
