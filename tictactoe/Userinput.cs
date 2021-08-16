using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Userinput : Form
    {
        public Userinput()
        {
            InitializeComponent();
        }
        public int n=0;
        public String l1;
        public String l2;
        private void player1label_Click(object sender, EventArgs e)
        {

        }

        private void Player2label_Click(object sender, EventArgs e)
        {

        }

        private void player1nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        //this is a method that that submits the names of the players inputted 
        private void submitbutton_Click(object sender, EventArgs e)
        {
            n = n + 1;
            l1 = player1nametextbox.Text;
            l2 = player2nametextbox.Text;

            Close();

        }

        private void Userinput_Load(object sender, EventArgs e)
        {

        }
    }
}
