using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    public class Transport
    {
        // types
        public enum Zustand { aus, an }
        public enum GeschwEinheit { kilometer, meilen }

        // props
        public string Name { get; set; }
        public int MaximalGeschwindigkeit { get; }
        public double Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        public Zustand FZustand { get; private set; }
        public List<Passagier> Passagierliste { get; set; }

        // ctor
        public Transport(string name, double preis, int maximalGeschwindigkeit)
        {
            Name = name;
            Preis = preis;
            MaximalGeschwindigkeit = maximalGeschwindigkeit;
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        // methods
        public int Beschleunigen(int erhöhung, GeschwEinheit geschwEinheit)
        {
            if(geschwEinheit == GeschwEinheit.meilen)
            {
                erhöhung = MeilenZuKm(erhöhung);
            }            
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && FZustand == Zustand.an)
            {
                AktuelleGeschwindigkeit += erhöhung;
            }
            else
            {
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;
            }
            return AktuelleGeschwindigkeit;
        }
        public void StarteMotor()
        {
            if (FZustand == Zustand.an)
            {
                AktuelleGeschwindigkeit += 5;
            }
        }

        public void StoppeMotor()
        {
            FZustand = Zustand.an;
        }

        public void Parke()
        {
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $"{Name} ({Preis} Euro): Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h | Zustand: {FZustand}| Mom. Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }

        public static double KmZuMeilen(int km)
        {
            double miles = km * 0.621371;
            return miles;
        }

        public static int MeilenZuKm(int meilen)
        {
            int km = (int)Math.Round(meilen * 1.60934);
            return km;
        }
    }
}
