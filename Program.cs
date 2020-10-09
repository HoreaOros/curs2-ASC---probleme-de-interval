using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ONLY NATURAL NUMBER INPUT

            // problema cu aceasta solutie este ca nu eficienta atunci cand a si b sunt numere mari. 
            // solutia implica o simpla formula in care se fac 3-4 operatii aritmetice. 
            Console.Write("Inceputul intervalului (a): ");
            string line1 = Console.ReadLine();
            int a = int.Parse(line1);

            Console.Write("Sfarsitul intervalului (b): ");
            string line2 = Console.ReadLine();
            int b = int.Parse(line2);

            Console.Write("k: ");
            string line3 = Console.ReadLine();
            int k = int.Parse(line3);

            int n = 0;

            // rezolvare de info
            for (int i = a; i < b; i++) { // aici ar trebui i <=b;
                if (i % k == 0) {
                    n++;
                }
            }
            Console.WriteLine($"{n} numere divizibile intre {a} si {b}");

            Console.WriteLine("___________________________________");

            // rezolvare de mate
            // asta e rezolvarea la care ma asteptam. formula e corecta. 
            int mate = (b / k) - (a - 1) / k;
            Console.WriteLine($"{mate}");

        }
    }
}
