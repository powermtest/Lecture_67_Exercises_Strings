using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5
{
    //5- Write a program and ask the user to enter an English word.
    //Count the number of vowels (a, e, o, u, i) in the word. 
    //So, if the user enters "inadequate", the program should display 6 on the console.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Wpisz jakieś angielskie słowo, a ja policzę ile jest w nim samogłosek");
            var input = Console.ReadLine();
            var licznik = 0;
            var licznikWieluSlow = 0;

            #region testing

            //var input = string.Empty;
            //var testPozytywny1 = "abandoment";
            //var testPozytywny2 = "aaaooouuuiiieee";
            //var testNeg1 = "cvbcvb";
            //var testNeg2 = "234 747";
            //var testNeg3 = "pierwsze i drugie";
            //input = testNeg3;

            #endregion


            var wieleSlow = input.ToLower().Split(' ');
            var obcinamyPoSpacji = input.ToLower().Trim(' ');

            if (wieleSlow.Length > 1)
            {
                foreach (var slowo in wieleSlow)
                {
                    if (!slowo.All(char.IsLetter))
                    {
                        Console.WriteLine("Oczekuje słów składających się wyłącznie z liter! Narka!");
                        return;
                    }
                    foreach (var literka in slowo)
                        if (literka == 'a' || literka == 'e' || literka == 'i' || literka == 'o' || literka == 'u')
                            licznikWieluSlow++;
                }

                if (licznikWieluSlow > 0)
                {
                    Console.WriteLine("Miało być jedno słowo... Ale OK...");
                    Console.WriteLine("Łącznie naliczyłem {0} samogłosek.", licznikWieluSlow);
                }
                else
                {
                    Console.WriteLine("Nie znalazłem żadnych samogłosek!");
                }

                //return;
            }
            else
            {
                foreach (var literka in obcinamyPoSpacji)
                    if (literka == 'a' || literka == 'e' || literka == 'i' || literka == 'o' || literka == 'u')
                        licznik++;

                if (licznik > 0)
                    Console.WriteLine("Łącznie znalazłem {0} samogłosek", licznik);
                else
                    Console.WriteLine("Nie znalazłem żadnych samogłosek!");
            }
        }
    }
}
