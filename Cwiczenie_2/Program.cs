using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_2
{
    //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
    //If the user simply presses Enter, without supplying an input, exit immediately; 
    //otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pare numerow oddzielonyh myslnikiem. Sprawdze czy sa duplikaty.");
            var input = Console.ReadLine();
            var listaLiczb = new List<int>();

            while (!string.IsNullOrWhiteSpace(input))
            {


                //if (string.IsNullOrWhiteSpace(input))
                //{
                //    Console.WriteLine("I trusted you! Bye!");
                //}

                var bezMyslnikow = input.Split('-');
                foreach (var liczba in bezMyslnikow)
                {
                    listaLiczb.Add(Convert.ToInt32(liczba));
                }

                var niepowtarzalne = listaLiczb.Distinct();
                if (niepowtarzalne.Count() == listaLiczb.Count)
                {
                    Console.WriteLine("nie ma duplikatow");
                }
                else
                {
                    Console.WriteLine("Sa duplikaty.");
                }
            }

            Console.WriteLine("I trusted you! Be gone!");
        }
    }
}
