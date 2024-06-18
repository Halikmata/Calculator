using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = !false;
            txtName.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //txtName.Visible = !txtName.Visible;
            if(btnUpdate.Text == "Update")
                btnUpdate.Text = "Save";

            else if (btnUpdate.Text == "Save")
                btnUpdate.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form_2 = new Form2();
            Form_2.Show();
            //this.Close();
        }
    }
}
