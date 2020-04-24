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
            MessageBox.Show($"\nAddiere: {a + b}");
            return a + b;
        }
        int Subtrahiere(int a, int b)
        {
            MessageBox.Show($"\nSubtrahiere: {a - b}");
            return a - b;
        }
        #endregion

        #region benutzerdefinierter Delegat
        // ein DelegatenTyp und damit ein Datentyp
        public delegate int IntIntIntDelegate(int a, int b);
        #endregion        

        IntIntIntDelegate iiidelegate;
        Func<int, int, int> myFuncDelegat;

        private void plusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Addiere);
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text)); // Variante 1
            label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)); // Variante 2
            myFuncDelegat = Addiere;
            label4.Text += myFuncDelegat(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Subtrahiere);
            label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            myFuncDelegat = Subtrahiere;
            label4.Text += myFuncDelegat(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Addiere);
            iiidelegate += Subtrahiere;
            label3.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            myFuncDelegat = null;
            myFuncDelegat = Addiere;
            myFuncDelegat += Subtrahiere;
            label4.Text += myFuncDelegat(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> städte = new List<string>() { "Bonn", "Paris", "Stuttgart", "München" };
            string gefundeneStadt;

            // anonyme Funktion
            gefundeneStadt = städte.Find(
                delegate (string s)
                {
                    return s.StartsWith("S");
                });

            // Pfeilfunktion
            gefundeneStadt = städte.Find(
                (string s) =>
                {
                    return s.StartsWith("M");
                });

            // Pfeilfunktion kürzer
            gefundeneStadt = städte.Find(s => s.StartsWith("P"));

            MessageBox.Show(gefundeneStadt);
        }
    }
}
