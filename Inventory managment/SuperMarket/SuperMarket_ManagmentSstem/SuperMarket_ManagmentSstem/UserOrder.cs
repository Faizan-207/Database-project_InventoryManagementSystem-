using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_ManagmentSstem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            userform user = new userform();
            user.Show();
        }

        private void itemGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
