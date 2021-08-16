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
    public partial class VSCPU : Form
    {
        public VSCPU()
        {
            InitializeComponent();
        }
        int counterai = 0; // counts the number of times the button is clicked both x and o
        int d0, d1, d2, d3, d4, d5, d6, d7, d8 = 0;
        int ttai = 0;
        int r1ai = 0;
        int r2ai = 0;


        private void button00_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d0 += 1;
            if (d0 == 1)
            {
                    button00.Text = "X";
                    smartmoves();
                    if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button01.Text == "")
                    {
                        button01.Text = "O";
                    d1 += 1;
                }
                    else if (button10.Text == "")
                    {
                        button10.Text = "O";
                    d3 += 1;
                }
                    else if (button21.Text == "")
                    {
                        button21.Text = "O";
                    d7 += 1;
                }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
            
        }

        private void button01_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d1 += 1;
            if (d1 == 1)
            {
                    button01.Text = "X";
                smartmoves();
                if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button02.Text == "")
                    {
                        button02.Text = "O";
                    d2 += 1;
                }
                    else if (button00.Text == "")
                    {
                        button00.Text = "O";
                        d0 += 1;
                    }
                    else if (button21.Text == "")
                    {
                        button21.Text = "O";
                    d7 += 1;
                }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d2 += 1;
            if (d2 == 1)
            {
                    button02.Text = "X";
                smartmoves();
                if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button22.Text == "")
                    {
                        button22.Text = "O";
                    d8 += 1;
                }
                    else if (button12.Text == "")
                    {
                        button12.Text = "O";
                    d5 += 1;
                }
                    else if (button20.Text == "")
                    {
                        button20.Text = "O";
                    d6 += 1;
                }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d3 += 1;
            if (d3 == 1)
            {
                    button10.Text = "X";
                smartmoves();
                if (button20.Text == "")
                    {
                        button20.Text = "O";
                    d6 += 1;
                }
                    else if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button00.Text == "")
                    {
                        button00.Text = "O";
                         d0 += 1;
                    }
                    else if (button01.Text == "")
                    {
                        button01.Text = "O";
                    d1 += 1;
                }
                    textBox.Text = "O";
                tictactoe();
                resultbox2();
            }
        }

        private void versusfriend_Click(object sender, EventArgs e)
        {
            Close();
            clearbuttonsai();
            counterai = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d4 += 1;
            if (d4 == 1)
            {
                    button11.Text = "X";
                smartmoves();
                if (button22.Text == "")
                    {
                        button22.Text = "O";
                    d8 += 1;
                }
                    else if (button12.Text == "")
                    {
                        button12.Text = "O";
                    d5 += 1;
                }
                    else if (button12.Text == "")
                    {
                        button12.Text = "O";
                    }
                    textBox.Text = "O";

                tictactoe();
                resultbox2();
            }
        }

        private void VSCPU_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d5 += 1;
            if (d5 == 1)
            {
                    button12.Text = "X";
                smartmoves();
                if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button22.Text == "")
                    {
                        button22.Text = "O";
                    d8 += 1;
                }
                    else if (button02.Text == "")
                    {
                        button02.Text = "O";
                    d2 += 1;
                }
                    else if (button10.Text == "")
                    {
                        button10.Text = "O";
                    d3 += 1;
                }
                    else if (button01.Text == "")
                    {
                        button01.Text = "O";
                    d1 += 1;
                }
                    else if (button21.Text == "")
                    {
                        button21.Text = "O";
                    d7 += 1;
                }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d6 += 1;
            if (d6 == 1)
            {

                    button20.Text = "X";
                smartmoves();
                    if (button10.Text == "")
                    {
                        button10.Text = "O";
                    d3 += 1;
                }
                    else if (button21.Text == "")
                    {
                        button21.Text = "O";
                    d7 += 1;
                }
                    else if (button00.Text == "")
                    {
                        button00.Text = "O";
                    d0 += 1;
                    }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d7 += 1;
            if (d7 == 1)
            {
                    button21.Text = "X";
                smartmoves();
                if (button22.Text == "")
                    {
                        button22.Text = "O";
                    d8 += 1;
                }
                    else if (button20.Text == "")
                    {
                        button20.Text = "O";
                    d6 += 1;
                }
                    else if (button11.Text == "")
                    {
                        button11.Text = "O";
                    d4 += 1;
                }
                    else if (button01.Text == "")
                    {
                        button01.Text = "O";
                    d1 += 1;
                }
                    else if (button12.Text == "")
                    {
                        button12.Text = "O";
                    d5 += 1;
                }
                    else if (button02.Text == "")
                    {
                        button02.Text = "O";
                    }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            counterai = counterai + 1;
            d8 += 1;
            if (d8 == 1)
            {
                    button22.Text = "X";
                smartmoves();
                    if (button00.Text == "")
                    {
                        button00.Text = "O";
                    d0 += 1;
                    }
                    else if (button02.Text == "")
                    {
                        button02.Text = "O";
                    d2 += 1;
                }
                    else if (button12.Text == "")
                    {
                        button12.Text = "O";
                    d5 += 1;
                }
                    textBox.Text = "O";
                
                tictactoe();
                resultbox2();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tictactoe()
        {
            if ((button00.Text == "X" && button11.Text == "X" && button22.Text == "X") || (button02.Text == "X" && button11.Text == "X" && button20.Text == "X"))
            {
                r1ai = r1ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE PLAYER WON THE GAME");
                clearbuttonsai();
            }
            else if ((button00.Text == "X" && button10.Text == "X" && button20.Text == "X") || (button01.Text == "X" && button11.Text == "X" && button21.Text == "X") || (button02.Text == "X" && button12.Text == "X" && button22.Text == "X"))
            {
                r1ai = r1ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE PLAYER WON THE GAME");
                clearbuttonsai();
            }
            else if ((button00.Text == "X" && button01.Text == "X" && button02.Text == "X") || (button10.Text == "X" && button11.Text == "X" && button12.Text == "X") || (button20.Text == "X" && button21.Text == "X" && button22.Text == "X"))
            {
                r1ai = r1ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE PLAYER WON THE GAME");
                clearbuttonsai();
            }

            else if ((button00.Text == "O" && button11.Text == "O" && button22.Text == "O") || (button02.Text == "O" && button11.Text == "O" && button20.Text == "O"))
            {
                r2ai = r2ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE ROBOT WON THE GAME");
                clearbuttonsai();
            }
            else if ((button00.Text == "O" && button10.Text == "O" && button20.Text == "O") || (button01.Text == "O" && button11.Text == "O" && button21.Text == "O") || (button02.Text == "O" && button12.Text == "O" && button22.Text == "O"))
            {
                r2ai = r2ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE ROBOT WON THE GAME");
                clearbuttonsai();
            }
            else if ((button00.Text == "O" && button01.Text == "O" && button02.Text == "O") || (button10.Text == "O" && button11.Text == "O" && button12.Text == "O") || (button20.Text == "O" && button21.Text == "O" && button22.Text == "O"))
            {
                r2ai = r2ai + 1;
                ttai = 1;
                counterai = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("THE ROBOT WON THE GAME");
                clearbuttonsai();
            }
            else if ((counterai == 5))
            {
                counterai = 0;
                MessageBox.Show(" DRAW ");
                clearbuttonsai();
            }
            else if (ttai == 1) {
                if (counterai == 4) {
                    counterai = 0;
                    MessageBox.Show(" DRAW ");
                    clearbuttonsai();
                }
            }




        }
        private void smartmoves() {
            if ((button10.Text == "O" && button11.Text == "O" && button12.Text=="") || (button02.Text=="O" && button22.Text=="O" && button12.Text=="")) {
                button12.Text = "O";  
            }
            else if ((button00.Text == "O" && button11.Text == "O" && button22.Text=="") || (button20.Text == "O" && button21.Text == "O" && button22.Text == "") || (button02.Text=="O" && button12.Text== "O" && button22.Text == ""))
            {
                button22.Text = "O";
            }
            else if ((button11.Text == "O" && button22.Text == "O" && button00.Text == "") || (button01.Text == "O" && button02.Text == "O" && button00.Text == "") || (button10.Text == "O" && button20.Text == "O" && button00.Text == ""))
            {
                button00.Text = "O";
            }
            else if ((button00.Text == "O" && button22.Text == "O" && button11.Text == "") || (button02.Text == "O" && button20.Text == "O" && button11.Text == "") || (button10.Text == "O" && button12.Text == "O" && button11.Text == "") || (button01.Text == "O" && button21.Text == "O" && button11.Text == ""))
            {
                button11.Text = "O";
            }
            else if ((button01.Text == "O" && button11.Text == "O" && button21.Text == "") || (button20.Text == "O" && button22.Text == "O" && button21.Text == ""))
            {
                button21.Text = "O";
            }
            else if ((button21.Text == "O" && button22.Text == "O" && button20.Text == "") || (button11.Text == "O" && button02.Text == "O" && button20.Text == "") || (button00.Text == "O" && button10.Text == "O" && button20.Text == ""))
            {
                button20.Text = "O";
            }
            tictactoe();

        }
        private void clearbuttonsai()
        {
            d0 = 0; d1 = 0; d2 = 0; d3 = 0; d4 = 0; d5 = 0; d6 = 0; d7 = 0; d8 = 0;
            button00.Text = "";
            button01.Text = "";
            button02.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";

        }
        private void resultbox2() {
            switch (r1ai) {
                case 1:
                    textBox1.Text = 1.ToString();
                    break;
                case 2:
                    textBox1.Text = 2.ToString();
                    break;
                case 3:
                    textBox1.Text = 3.ToString();
                    break;
                case 4:
                    textBox1.Text = 4.ToString();
                    break;
                case 5:
                    textBox1.Text = 5.ToString();
                    break;
            }
            switch (r2ai) {
                case 1:
                    textBox2.Text = 1.ToString();
                    break;
                case 2:
                    textBox2.Text = 2.ToString();
                    break;
                case 3:
                    textBox2.Text = 3.ToString();
                    break;
                case 4:
                    textBox2.Text = 4.ToString();
                    break;
                case 5:
                    textBox2.Text = 5.ToString();
                    break;
            }
   }
        }
 
}
