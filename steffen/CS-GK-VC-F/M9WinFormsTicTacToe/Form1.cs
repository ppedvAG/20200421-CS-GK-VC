using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9WinFormsTicTacToe
{
    public partial class Form1: Form
    {
        //ctor
        
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0; 
        void CountSteps(object senderobj)
        {
            string btntext = ((Button)senderobj).Text;
            if (btntext == "")
            {
                if (counter % 2 == 0)
                {
                    ((Button)senderobj).Text = "X";
                    CheckWinner("X");
                }
                else
                {
                    ((Button)senderobj).Text = "O";
                    CheckWinner("O");
                }
                counter++;
            }
            else
            {
                MessageBox.Show("Bist du blind!? Klick woanders!");
            }
        }

        void CheckWinner(string x_or_o)
        {
            if(button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button2.Text == x_or_o && button5.Text == x_or_o && button8.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
            {
                label3.Text += x_or_o;
                MessageBox.Show(x_or_o + " hat gewonnen!");
                Environment.Exit(0);
            }
            else if (counter == 8)
            {
                MessageBox.Show("Unentschieden!");
                Environment.Exit(0);

            }
            {
            }
            {

            }
            {

            }
            {

            }
            {

            }
            {

            }
            {

            }
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CountSteps(sender);
        }
    }
}
