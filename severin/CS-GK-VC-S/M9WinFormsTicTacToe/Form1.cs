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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int counter = 0;
		void CountStps(object senderobject)
		{
			string buttonText = ((Button)senderobject).Text;
			if (buttonText == "")
			{
				if (counter % 2 == 0)
				{
					((Button)senderobject).Text = "X";
					checkWinner("X");
				}
				else
				{
					((Button)senderobject).Text = "O";
					checkWinner("O");
				}
				counter = counter + 1;
			}
			else
			{
				MessageBox.Show("Bist Du Blind!? Klick woanders!");
			}
		}

		void checkWinner(string x_or_o)
		{
			if (button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if(button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button2.Text == x_or_o && button5.Text == x_or_o && button8.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
			{
				MessageBox.Show(x_or_o + "Hat Gewonnen");
				label3.Text += x_or_o;
			}
			else if (counter == 8)
			{
				MessageBox.Show("Unentschieden, macht lieber Sport!");
				Environment.Exit(0);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			CountStps(sender);
		}
	}
}
