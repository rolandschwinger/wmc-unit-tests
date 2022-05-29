using System;
using FUHRPARK_LIB;

namespace WMC_FuhrparkUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            KFZ[] kfzs = new KFZ[] {
                new KFZ("BMW", 120),
                new PKW("Audi", 110, "G 643UV"),
                new PKW("BMW", 130, "W 6352T"),
                new LKW("MAN", 410, "W 7663E", 40),
                new LKW("Volvo", 520, "G 643UV", 60)
            };
           
            // ---
            // 4. OOP
            // 4.1. Ermittle alle Kfz mit PS-Zahl > 200
            Fuhrpark fP = new Fuhrpark(kfzs);
            int anz = fP.GetAnzKfzPS(200);
            Console.WriteLine("\nEs gibt {0} Autos mit einer PS-Zahl > 200", anz);

            // 4.2. Ermittle KFZs aus Wien
            Console.WriteLine("\nKFZs aus Wien");
            foreach(KFZ kfz in fP.GetKFZsAus("W"))
            {
                Console.WriteLine("{0}", kfz);
            }

            // 4.3 LKW mit größter Ladefläche
            Console.WriteLine("\nLKW mit größter Ladefläche");
            Console.WriteLine("{0}", fP.GetMaxLoadLKW());

        }
    }
}
