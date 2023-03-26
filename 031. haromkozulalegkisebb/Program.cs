using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031.haromkozulalegkisebb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy harmadik számot is!");
            int szam3 = Convert.ToInt32(Console.ReadLine());

            {
                if (szam1 < szam2 && szam1 < szam3)
                    Console.WriteLine("A legkisebb szám: " + szam1 + "." + "\n");
                
                else if (szam2 < szam3 && szam2 < szam1)
                    Console.WriteLine("A legkisebb szám: " + szam2 + "." + "\n");

                else
                    Console.WriteLine("A legkisebb szám: " + szam3 + "." + "\n");

            }
        
            Console.ReadKey();
        }
    }
}
