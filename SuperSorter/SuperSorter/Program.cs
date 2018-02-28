//Opgaven handler om at bruge forskellige metoder at lave den samme sortering. Vi kan sortere med forskellige
//algoritmer. I stedet for at give det hele forskellige klasser og metoder, så kan vi bare bruge en abstrakt
//klasse som ændre sig med hvad man bruger.
//Steps:
//Lav en generel sammenhængende klasse (Noget de forskellige algoritmer har tilsammen)
//Lav implementering som abstrakte klasser
//Afprøv de forskellige klasser i main (Polymorfi)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter
{
    class Mainnew
    {
        static void Main(string[] args)
        {
            string input;
            int n, seed;

            Console.WriteLine($"Indtast storrelsen af Array, derefter Seed:");

            input  = Console.ReadLine();
            Int32.TryParse(input, out n);

            input = Console.ReadLine();
            Int32.TryParse(input, out seed);

            Supersorting obj = new Supersorting();

            if (!Int32.TryParse(input, out n))
            {
                Console.WriteLine($"Error: Properly no letters.");
                //no, not able to parse, repeat, throw exception, use fallback value?
            }

            if (!Int32.TryParse(input, out seed))
            {
                Console.WriteLine($"Not a number.");
            }
            else
            {
                obj.ArrayGenerator(n, seed);
            }
            
            
            
        }
       
    }

    public class Supersorting
    {
        public int[] ArrayGenerator(int n, int seed)
        {
            Random rng = new Random(seed);
            int[] array = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int a = rng.Next(0, n+1);
                array[i] = a;
                Console.WriteLine($"{array[i]}");
            }
            return array;
        }
    }
}

