using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    public class Transportmittel
    {

        public enum MotorZustand
        {
            Aus, An
        }

        public enum InEinheit { kilometer, meilen }
        
        public string MyName { get; set; }

        public int MyMaxGeschwindigkeit { get; }

        public double MyPrice { get; set; }

        public int MyActGeschwindigkeit { get; set; }

        // Zustand nur über Methoden änderbar
        public MotorZustand MyZustand { get; private set; }

        public List<Passagier> Passagierliste { get; set; }

        //Construktor
        public Transportmittel (string InName, int InMaxG, double InPrice, int InActG)
        {
            MyName = InName;
            MyMaxGeschwindigkeit = InMaxG;
            MyPrice = InPrice;
            MyActGeschwindigkeit = InActG;
            MyZustand = MotorZustand.Aus;

        }

        public int  Beschleunige(int InErhöhung, InEinheit inEinheit)
        {
            if (inEinheit  == InEinheit.meilen)
            {
                InErhöhung = MilesToKm(InErhöhung);
            }
            // wenn miles kommen, vorher umrechnen

            MyActGeschwindigkeit += InErhöhung;


            if (MyActGeschwindigkeit > MyMaxGeschwindigkeit)
            {
                return MyMaxGeschwindigkeit;
            }
            else
            {
                return MyActGeschwindigkeit;
            }

        }

        public void StarteMotor()
        {
            MyZustand = MotorZustand.An;
        }

        public void StoppeMotor()
        {
            MyZustand = MotorZustand.Aus;
        }

        public virtual string BeschreibeMich()
        {
            return $"Name: {MyName}, Geschwindikeit Max: {MyMaxGeschwindigkeit}, " +
                $"Geschwindigkeit aktuell: {MyActGeschwindigkeit}, Preis: {MyPrice}, " +
                $"Zustand: {MyZustand}";
        }

        public static double KmToMiles(int km)
        {
            double miles = km * 0.621371;
            return miles;
             
        }

        public static int MilesToKm (int meilen)
        {
            int  km =(int)Math.Round(meilen * 1.60934);
            return km;

        }
    }


}
