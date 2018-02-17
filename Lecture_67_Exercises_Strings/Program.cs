using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercises_Strings
{
    class Program
    {
        //1- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. 
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
        //otherwise, display "Not Consecutive".
        static void Main(string[] args)
        {
            var wpisaneLiczby = "";
            
            Console.WriteLine("Wpisz kilka liczb oddzielonych myslnikiem");
            Console.WriteLine("Sprawdze czy sa to kolejne liczby i to zakomunikuje");
            wpisaneLiczby = Console.ReadLine();
            //var a = 0;
            //var b = 1;

            if (string.IsNullOrWhiteSpace(wpisaneLiczby))
            {
                Console.WriteLine("szkoda, ze nie chcesz sie bawic. Narka.");
              
            }
            else
            {
                var tablicaWpisanychLiczb = wpisaneLiczby.Split('-');
                for (int i = 0; i < tablicaWpisanychLiczb.Length; i++)
                {
                    var max = Convert.ToInt32(tablicaWpisanychLiczb[i]);
                    //var liczbaWieksza = Convert.ToInt32(tablicaWpisanychLiczb[i+1]);

                    if (max +1 == Convert.ToInt32(tablicaWpisanychLiczb[i + 1])|| i < tablicaWpisanychLiczb.Length)
                    {
                        Console.WriteLine("Liczba wieksza");
                        //max = liczbaWieksza;
                        //liczbaWieksza++;
                    }
                    foreach (var liczba in tablicaWpisanychLiczb)
                    {
                        if (liczba==)
                        {
                            
                        }
                    }
                }
                
            }
        }
    }
}
