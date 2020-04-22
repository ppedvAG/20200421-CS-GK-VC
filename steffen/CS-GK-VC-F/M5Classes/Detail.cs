using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Demo_Library
{
    public class Detail
    {
        public enum Einheit
        {
            cm, m
        }
        // Props
        // in cm
        public double Höhe { get; set; }
        
        public double Breite { get; set; }

        // Constructor
        public Detail(double h, double b)
        {
            Höhe = h;
            Breite = b;
        }

        // Methoden
        public static void SagHalloStatic()
        {
            Console.WriteLine("Hallo static");
        }

        public void SagHallo()
        {
            Console.WriteLine("Hallo void");
        }

        public void SetHöhe(double h, Einheit e)
        {
            if (e == Einheit.cm)
            {
                Höhe = h;
            }
            else
            {
                Höhe = Umrechnung.MToCm(h);
            }
        }
    }
}
