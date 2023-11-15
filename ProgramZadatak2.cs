using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prvi, drugi, konacno;

            Console.WriteLine("Upišite prvi stringa: ");
            prvi = Console.ReadLine();
            Console.WriteLine("Upišite drugi string: ");
            drugi = Console.ReadLine();

            string[] rijeci = new string[] { prvi, drugi };
            Array.Sort(rijeci);

            foreach (string rijec in rijeci)
            {
                Console.WriteLine(rijec);
            }

            Console.ReadKey();
        }
    }
}
