using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SLAM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Modele clio = new Modele("clio", 12000);
            Voiture Bartmobile = new Voiture(clio, "372 qq 95");
            Vehicule V = new Vehicule("452 ni 35");

            V.AddOption(new Option("CD audio", 230));
            V.AddOption(new Option("Air conditionné", 395));
            clio.AddOption(new Option("Direction assistée", 250));
            clio.AddOption(new Option("Air Bag", 320));
            Bartmobile.AddOption(new Option("CD audio", 230));
            Bartmobile.AddOption(new Option("Air Conditionné", 395));

            Console.WriteLine(clio.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(Bartmobile.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(V.ToString());

            Console.ReadLine();

            
        }
    }
}
