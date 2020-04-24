using M5Fuhrpark;
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

            // IN EINE DATEI SCHREIBEN
            Transport transport = new Transport("BMW", 50000, 250);
            string jsonString = JsonConvert.SerializeObject(transport);
            StreamWriter streamWriter = new StreamWriter("Transportmittel.json");
            streamWriter.Write(jsonString);
            streamWriter.Close();

            // AUS EINER DATEI LESEN
            StreamReader streamReader = new StreamReader("Transportmittel.json");
            var objekt = JsonConvert.DeserializeObject<Transport>(streamReader.ReadToEnd());
            streamReader.Close();
            Console.WriteLine($"objekt is Transport: {objekt is Transport}");
            Console.WriteLine($"objekt: {objekt.BeschreibeMich()}");

            objekt.Beschleunigen(5, Transport.GeschwEinheit.kilometer);

            Schreibe<Transport>(objekt);

            Object o = new object();

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
