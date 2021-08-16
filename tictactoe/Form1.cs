using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tictactoe
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //Userinput is a class that let's us store the names of the players 
        Userinput u = new Userinput();
        
        
        // THE VS FRIEND VARIABLES

        int counter = 0; // stores the number of times the button is clicked both x and o , and mainly used incase of a draw
        int c0, c1, c2, c3, c4, c5, c6, c7, c8 = 0; // lets's the buttons not change their x or o vlaue once they are clicked
        int aa = 0; // stores the number of times player 1 won 
        int bb = 0; // stores the number of times player 2 won
        int n = 1; // determines if the game is "VS CPU" or "VS FRIEND"

        // THE VS CPU VARIABLES

        int counterai = 0; // stores the number of times the button is clicked both x and o , and mainly used incase of a draw
        int d0, d1, d2, d3, d4, d5, d6, d7, d8 = 0; // lets's the buttons not change their x or o vlaue once they are clicked
        int ttai = 0;
        int r1ai = 0;
        int r2ai = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button00_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c0 += 1;
                if (c0 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button00.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button00.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }

            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button01_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c1 += 1;
                if (c1 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button01.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button01.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button02_Click(object sender, EventArgs e)
        {
            changelabel();
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c2 += 1;
                if (c2 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button02.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button02.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c3 += 1;
                if (c3 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button10.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button10.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void versuscpu_Click(object sender, EventArgs e)
        {
            n = n + 1;
            clearbuttonsai();
            clearbuttons();
            changeversusbutton();
            changelabel();



        }

        private void textBoxresult1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxresult2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c4 += 1;
                if (c4 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button11.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button11.Text = "X";
                        textBox.Text = "X";
                    }

                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            u.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c5 += 1;
                if (c5 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button12.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button12.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button20_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c6 += 1;
                if (c6 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button20.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button20.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button21_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c7 += 1;
                if (c7 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button21.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button21.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }

        private void button22_Click(object sender, EventArgs e)
        {
            changelabel();

            //This if statement is implemented when playing versus a friend
            if (n % 2 != 0)
            {
                counter = counter + 1;
                c8 += 1;
                if (c8 == 1)
                {
                    if (textBox.Text == "X")
                    {
                        button22.Text = "O";
                        textBox.Text = "O";
                    }
                    else
                    {
                        button22.Text = "X";
                        textBox.Text = "X";
                    }
                    tictac();
                    result();
                }
            }
            //This if statement is implemented when playing versus the cpu
            else
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
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        //tictac is a method that determines the winner based on the game rule when playing in versus player mode
        private void tictac()
        {
            if ((button00.Text == "X" && button11.Text == "X" && button22.Text == "X") || (button02.Text == "X" && button11.Text == "X" && button20.Text == "X"))
            {
               
                aa += 1;
                counter = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("X WON THE GAME");
                colorclear();
                clearbuttons();
            }
            else if ((button00.Text == "X" && button10.Text == "X" && button20.Text == "X") || (button01.Text == "X" && button11.Text == "X" && button21.Text == "X") || (button02.Text == "X" && button12.Text == "X" && button22.Text == "X"))
            {
                
                aa += 1;
                counter = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("X WON THE GAME");
                colorclear();
                clearbuttons();
            }
            else if ((button00.Text == "X" && button01.Text == "X" && button02.Text == "X") || (button10.Text == "X" && button11.Text == "X" && button12.Text == "X") || (button20.Text == "X" && button21.Text == "X" && button22.Text == "X"))
            {
                aa += 1;
                counter = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("X WON THE GAME");
                clearbuttons();
            }

            else if ((button00.Text == "O" && button11.Text == "O" && button22.Text == "O") || (button02.Text == "O" && button11.Text == "O" && button20.Text == "O"))
            {
                
                bb += 1;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("O WON THE GAME");
                colorclear();
                clearbuttons();
            }
            else if ((button00.Text == "O" && button10.Text == "O" && button20.Text == "O") || (button01.Text == "O" && button11.Text == "O" && button21.Text == "O") || (button02.Text == "O" && button12.Text == "O" && button22.Text == "O"))
            {
                
                bb += 1;
                counter = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("O WON THE GAME");
                colorclear();
                clearbuttons();
            }
            else if ((button00.Text == "O" && button01.Text == "O" && button02.Text == "O") || (button10.Text == "O" && button11.Text == "O" && button12.Text == "O") || (button20.Text == "O" && button21.Text == "O" && button22.Text == "O"))
            {
                bb += 1;
                counter = 0;
                MessageBox.Show("TIC TAC TOE");
                MessageBox.Show("O WON THE GAME");
                clearbuttons();
            }
            else if ((counter == 9))
            {
                counter = 0;
                MessageBox.Show(" DRAW ");
                clearbuttons();
            }



        }
        private void clearbuttons()
        {
            c0 = 0; c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0; c6 = 0; c7 = 0; c8 = 0;
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

        //this method calculates the score of the players
        private void result()
        {
            if (aa == 1)
            {
                textBoxresult1.Text = aa.ToString();
            }
            else if (aa == 2)
            {
                textBoxresult1.Text = aa.ToString();
            }
            else if (aa == 3)
            {
                textBoxresult1.Text = aa.ToString();
            }
            if (bb == 1)
            {
                textBoxresult2.Text = bb.ToString();
            }
            else if (bb == 2)
            {
                textBoxresult2.Text = bb.ToString();
            }
            else if (bb == 3)
            {
                textBoxresult2.Text = bb.ToString();
            }
        }
       
        private void colorclear() {
            button00.BackColor = Color.Tomato;
            button01.BackColor = Color.Tomato;
            button02.BackColor = Color.Tomato;
            button10.BackColor = Color.Tomato;
            button11.BackColor = Color.Tomato;
            button12.BackColor = Color.Tomato;
            button20.BackColor = Color.Tomato;
            button21.BackColor = Color.Tomato;
            button22.BackColor = Color.Tomato;
        }

        //changeversusbutton is a method that changes the button text to "vs cpu" or to "vs friend"
        private void changeversusbutton() {
            if (n % 2 != 0)
            {
                versuscpu.Text = "VS cpu";
            }
            else {
                versuscpu.Text = "VS friend";
            }
        }

        //tictactoe is a method that determines the winner based on the game rule when playing versus the cpu
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
            else if (ttai == 1)
            {
                if (counterai == 4)
                {
                    counterai = 0;
                    MessageBox.Show(" DRAW ");
                    clearbuttonsai();
                }
            }




        }

        //Smart move is a method implemented when played versus the cpu
        //And it is a method that lets the cpu decide which moves to make when playing versus a player

        private void smartmoves()
        {
            if ((button10.Text == "O" && button11.Text == "O" && button12.Text == "") || (button02.Text == "O" && button22.Text == "O" && button12.Text == ""))
            {
                button12.Text = "O";
            }
            else if ((button00.Text == "O" && button11.Text == "O" && button22.Text == "") || (button20.Text == "O" && button21.Text == "O" && button22.Text == "") || (button02.Text == "O" && button12.Text == "O" && button22.Text == ""))
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

        //resultbox2 is a method that displayes the scores of the players
        private void resultbox2()
        {
            switch (r1ai)
            {
                case 1:
                    textBoxresult1.Text = 1.ToString();
                    break;
                case 2:
                    textBoxresult1.Text = 2.ToString();
                    break;
                case 3:
                    textBoxresult1.Text = 3.ToString();
                    break;
                case 4:
                    textBoxresult1.Text = 4.ToString();
                    break;
                case 5:
                    textBoxresult1.Text = 5.ToString();
                    break;
            }
            switch (r2ai)
            {
                case 1:
                    textBoxresult2.Text = 1.ToString();
                    break;
                case 2:
                    textBoxresult2.Text = 2.ToString();
                    break;
                case 3:
                    textBoxresult2.Text = 3.ToString();
                    break;
                case 4:
                    textBoxresult2.Text = 4.ToString();
                    break;
                case 5:
                    textBoxresult2.Text = 5.ToString();
                    break;
            }
        }

        // changelabel is a method that displays the names of the inputted player names
        private void changelabel() {
            if (n % 2 != 0)
            {
                p1.Text = u.l1;
                textBoxresult1.Text = "";
                p2.Text = u.l2;
                textBoxresult2.Text = "";
            }
            else {
                p1.Text = u.l1;
                textBoxresult1.Text = "";
                p2.Text = "CPU";
                textBoxresult2.Text = "";
            }


        }

       


    }
}
            
    

