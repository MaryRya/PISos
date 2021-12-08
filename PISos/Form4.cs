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
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnonForm newForm = new AnonForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
