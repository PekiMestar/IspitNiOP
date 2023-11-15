using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst, novi;

            Console.WriteLine("Upišite neki tekst: ");
            tekst = Console.ReadLine();

            novi = tekst.Replace(" ", "_");

            Console.WriteLine(novi);

            Console.ReadKey();
        }
    }
}
