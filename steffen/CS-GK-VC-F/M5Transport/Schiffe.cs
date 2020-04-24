using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    public class Schiffe : Transportmittel, IKannTransportieren
    {
        public int AnzahlDecks { get; set; }
        public int AnzahlGeladen { get; set; }
   
        public Transportmittel Ladung { get; set; }

        public Schiffe(string InName, int InMaxG, double InPrice, int InActG, int InAnzDecks) : base(InName, InMaxG, InPrice, InActG)
        {
            AnzahlDecks = InAnzDecks;
            AnzahlGeladen = 0;
        }


        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $", Anzahl Decks: {AnzahlDecks}, Anzahl geladen: {AnzahlGeladen}.";
        }

        public int Beladen(Transportmittel transportmittel)
        {
            AnzahlGeladen++;
            Ladung = transportmittel;
            return AnzahlGeladen;
        }
    }
}
