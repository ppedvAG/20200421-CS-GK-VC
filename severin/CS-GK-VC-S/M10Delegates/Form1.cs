using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10Delegates
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Methoden für einen Delegaten
		int Addiere(int a, int b)
		{
			MessageBox.Show($"\nAddiere: {a + b}"); // ruft MessageBox auf
			return a + b;
		}
		
		int Subtrahiere(int a, int b)
		{
			MessageBox.Show($"\nSubtrahiere: {a - b}");
			return a - b;
		}
		#endregion
		// ein Delegaten Typ und damit ein Datentyp 
		#region benutzerdefinierter Delegat
		public delegate int IntIntIntDelegate(int a, int b);
		#endregion

		IntIntIntDelegate iiidelegate;
		Func<int, int, int> myFuncDelegate;
		private void PlusButton_Click(object sender, EventArgs e)
		{
			iiidelegate = new IntIntIntDelegate(Addiere);
			//iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text)); // Variante 1
			label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)); // Variante 2
			myFuncDelegate = Addiere;
			label4.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
		}

		private void MinusButton_Click(object sender, EventArgs e)
		{
			iiidelegate = iiidelegate = new IntIntIntDelegate(Subtrahiere);
			label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
			myFuncDelegate = Subtrahiere;
			label4.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
		}

		private void PlusMinusButton_Click(object sender, EventArgs e)
		{
			iiidelegate = new IntIntIntDelegate(Addiere);
			iiidelegate += Subtrahiere;
			label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
			myFuncDelegate = null;
			myFuncDelegate = Addiere;
			myFuncDelegate += Subtrahiere;
			label4.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<string> städte = new List<string>() { "Bonn", "Paris", "Stuttgart", "München" };
			// anonyme Funktion
			string gefundeneStadt = städte.Find(delegate (string s)
			{
				return s.StartsWith("S");
			});
			
			// Pfeilfunktion
			gefundeneStadt = städte.Find(
				(string s) =>
				{
					return s.StartsWith("S");
				});
			
			// Pfeilfunktion kurz
			gefundeneStadt = städte.Find(s => s.StartsWith("P");
				});
			MessageBox.Show(gefundeneStadt);
		}

	}
}
