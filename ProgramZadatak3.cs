using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int prvi = 0, drugi = 1, konacni = 0, n = 0;

            Console.WriteLine("Unesite broj n:");
            n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("N-ti član niza za " + n + " je: " + n);
            }

            else if (n == 1)
            {
                Console.WriteLine("N-ti član niza za " + n + " je: " + n);
            }

            else
            {
                for (int i = 2; i <= n; i++)
                {
                    konacni = prvi + drugi;
                    prvi = drugi;
                    drugi = konacni;
                }
            }

            Console.WriteLine("N-ti član niza za  " + n + " je: " + konacni);

            Console.ReadKey();
        }
    }
}
