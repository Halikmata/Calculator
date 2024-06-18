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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        public int compMove = 0, playMove = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //move of the computer is random but is assigned to a string
            compMove = rnd.Next(1, 4);

            if (compMove == 1)
                txtComputer.Text = "Rock";
            else if (compMove == 2)
                txtComputer.Text = "Paper";
            else if (compMove == 3)
                txtComputer.Text = "Scissor";

            //assigns player move to int for checking
            if (cboPlayer.Text == "Rock")
                playMove = 1;
            else if (cboPlayer.Text == "Paper")
                playMove = 2;
            else if (cboPlayer.Text == "Scissor")
                playMove = 3;

            //checks the winner
            if (playMove == compMove)
            {
                MessageBox.Show("Draw");
            }
            else if ((playMove == 1) && (compMove == 2))
            {
                MessageBox.Show("Computer won");
            }
            else if ((playMove == 1) && (compMove == 3))
            {
                MessageBox.Show("Player won");
            }
            else if ((playMove == 2) && (compMove == 1))
            {
                MessageBox.Show("Player won");
            }
            else if ((playMove == 2) && (compMove == 3))
            {
                MessageBox.Show("Computer won");
            }
            else if ((playMove == 3) && (compMove == 1))
            {
                MessageBox.Show("Computer won");
            }
            else if ((playMove == 3) && (compMove == 2))
            {
                MessageBox.Show("Player won");
            }

        }
    }
}
