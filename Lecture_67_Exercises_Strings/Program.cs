using System;
using System.Collections.Generic;
using System.Linq;

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
            var wpisaneLiczby = string.Empty;

            Console.WriteLine("Wpisz kilka liczb oddzielonych myslnikiem");
            Console.WriteLine("Sprawdze czy sa to kolejne liczby i to zakomunikuje");
            wpisaneLiczby = Console.ReadLine();
            var listaLiczb = new List<int>();
            var ciagMalejacy = false;
            var ciagRosnacy = true;

            if (string.IsNullOrWhiteSpace(wpisaneLiczby))
            {
                Console.WriteLine("szkoda, ze nie chcesz sie bawic. Narka.");
            }
            else
            {
                var tablicaWpisanychLiczb = wpisaneLiczby.Split('-');
                foreach (var VARIABLE in tablicaWpisanychLiczb)
                {
                    listaLiczb.Add(Convert.ToInt32(VARIABLE));
                }

                if (ciagRosnacy)
                {
                    for (int i = 1; i < listaLiczb.Count; i++)
                    {
                        if (listaLiczb.ElementAt(i) != (listaLiczb.ElementAt(i - 1)) + 1)
                        {
                            ciagRosnacy = false;
                            ciagMalejacy = true;
                            break;
                        }
                    }
                }

                if (ciagMalejacy)
                {
                    for (int i = 1; i < listaLiczb.Count; i++)
                    {
                        if (listaLiczb.ElementAt(i) != (listaLiczb.ElementAt(i - 1) - 1))
                        {
                            ciagMalejacy = false;
                            break;
                        }
                    }
                }
            }

            if (ciagRosnacy)
            {
                Console.WriteLine("Ciag jest rosnacy!");
            }
            else if (ciagMalejacy)
            {
                Console.WriteLine("Ciag jest malejacy!");
            }
            else
            {
                Console.WriteLine("Liczby nie stanowia ciagu ani rosnacego, ani malejacego.");
            }
        }
    }
}
