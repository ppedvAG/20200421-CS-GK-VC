using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    public class Flugzeuge : Transportmittel, IKannRollen
    {
        public int Flughöhe { get; set; }
        public int AnzahlRäder { get; set; }
        public int Luftdruck { get; set; }



        public Flugzeuge(string InName, int InMaxG, double InPrice, int InActG, int InFlughöhe) : base(InName, InMaxG, InPrice, InActG)
        {
            Flughöhe = InFlughöhe;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $", Flughöhe: {Flughöhe}.";
        }

        
        public int LuftdruckFüllen(int luft)
        {
            Luftdruck += luft;
            return Luftdruck;
        }
    }
}
