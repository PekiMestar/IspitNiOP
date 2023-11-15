using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stranice;

            unos:

            Console.WriteLine("Upiši stranice trokuta odvojene razmakom: ");
            stranice = Console.ReadLine();

            string[] brojevi = stranice.Split(' ');

            double.TryParse(brojevi[0], out double BrojA);
            double.TryParse(brojevi[1], out double BrojB);
            double.TryParse(brojevi[2], out double BrojC);

            if (BrojA <= 0 || BrojB <= 0 || BrojC <= 0)
            {
                Console.WriteLine("Pogrešan upis pokušajte ponovno! ");
                goto unos;
            }

            else if (BrojA > BrojB && BrojA > BrojC)
            {
                if (Math.Pow(BrojB, 2) + Math.Pow(BrojC, 2) == Math.Pow(BrojA, 2))
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan!");
                }
            }

            else if (BrojB > BrojA && BrojB > BrojC)
            {
                if (Math.Pow(BrojA, 2) + Math.Pow(BrojC, 2) == Math.Pow(BrojB, 2))
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan!");
                }
            }

            else if (BrojC > BrojA && BrojC > BrojB)
            {
                if (Math.Pow(BrojA, 2) + Math.Pow(BrojB, 2) == Math.Pow(BrojC, 2))
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan!");
                }
            }

            Console.ReadKey();
        }
    }
}
