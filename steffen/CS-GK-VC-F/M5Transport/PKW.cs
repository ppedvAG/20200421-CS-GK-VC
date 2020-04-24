using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    public class PKW : Transportmittel, IKannRollen
    {
        public enum MyAntrieb
        {
            Front, Heck, Allrad
        }
        public MyAntrieb Antrieb { get; set; }
        public int AnzahlRäder { get; set; }
        public int Luftdruck { get; set; }

        public PKW(string InName, int InMaxG, double InPrice, int InActG, MyAntrieb myAntrieb) : base(InName, InMaxG, InPrice, InActG)
        {
            Antrieb = myAntrieb;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $", Antrieb: {Antrieb}.";
        }

        
        public int LuftdruckFüllen(int luft) 
        {
            Luftdruck += luft; 
            return Luftdruck;
        }
    }
}
