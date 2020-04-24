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

        #region Methoden für einen Delegate

        public static int Addiere(int a, int b)
        {
            MessageBox.Show($"Addiere: {a + b}");
            //Console.WriteLine($"Addiere: {a + b}");
            return a + b;

        }

        public static int Substrahiere(int a, int b)
        {
            MessageBox.Show($"Substrahiere: {a - b}");
            //Console.WriteLine($"Substrahiere: {a - b}");
            return a - b;

        }
        #endregion

        #region benutzerdefinierte Delegate
        // ein Typ von Delegate und gleichzeitig ein Datentyp (neue Klasse)
        public delegate int IntIntIntDelegate(int a, int b);

        #endregion

        IntIntIntDelegate iiidelegate;
        Func<int, int, int> myFuncDelegate;


        private void label1_Click(object sender, EventArgs e)
        {
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text);
            //label4.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text);
            iiidelegate = new IntIntIntDelegate(Addiere);
            label4.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            myFuncDelegate = Addiere;
            ErgebnisFunc.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Substrahiere);
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text);
            label4.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            myFuncDelegate = Substrahiere;
            ErgebnisFunc.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void plusminusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Addiere);
            iiidelegate += Substrahiere;
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text);
            label4.Text += iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            myFuncDelegate = null;
            myFuncDelegate = Addiere;
            myFuncDelegate += Substrahiere;
            ErgebnisFunc.Text += myFuncDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> städte = new List<string>() { "Bonn", "Paris", "Stuttgart", "München" };
            // anonyme Funktion
            string gefundeneStadt = städte.Find(
                delegate (string s)
                {
                    return s.StartsWith("S");
                }
                );
            MessageBox.Show(gefundeneStadt);
            // Pfeilfunktion
            gefundeneStadt = städte.Find(
                 (string s) =>
                {
                    return s.StartsWith("M");
                }
                );
            MessageBox.Show(gefundeneStadt);
            // Pfeilfunktion kürzer
            gefundeneStadt = städte.Find(
                 s => s.StartsWith("P")
                 );
            MessageBox.Show(gefundeneStadt);
        }
    }
}
