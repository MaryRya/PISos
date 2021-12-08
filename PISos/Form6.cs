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
    }
}
