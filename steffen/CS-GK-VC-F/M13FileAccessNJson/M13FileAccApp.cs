using M5Transport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M13FileAccessNJson
{
    class M13FileAccApp
    {
        static void Main(string[] args)
        {
            // Daten geschrieben
            Schiffe schiffe = new Schiffe("Schiff 2", 254, 78000, 0, 3);
            PKW pKW = new PKW("Audi", 250, 45000, 0, PKW.MyAntrieb.Front);
            schiffe.Beladen(pKW);
            string jsonString = JsonConvert.SerializeObject(schiffe);
            StreamWriter streamWriter = new StreamWriter("Transportmittel.json");
            streamWriter.Write(jsonString);
            streamWriter.Close();

            // Daten lesen
            StreamReader streamReader = new StreamReader("Transportmittel.json");
            var objekt = JsonConvert.DeserializeObject<Schiffe>(streamReader.ReadToEnd());
            Console.WriteLine($"Objekt ist Schiffe: {objekt is Schiffe}");
            Console.WriteLine(objekt.BeschreibeMich());
            streamReader.Close();

            objekt.Beschleunige(47, Transportmittel.InEinheit.kilometer);
            Schreibe<Schiffe>(objekt);

            Console.ReadKey();
        }


        static void Schreibe<T>(T o)
        {
            StreamWriter streamWriter1 = new StreamWriter("Transportmittel.json");
            string jsonString = JsonConvert.SerializeObject(o);
            streamWriter1.Write(jsonString);
            streamWriter1.Close();
        }


    }
}
