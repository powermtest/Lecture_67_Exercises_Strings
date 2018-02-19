using System;

namespace Cwiczenie_3
{
    //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
    //A valid time should be between 00:00 and 23:59.
    //If the time is valid, display "Ok"; otherwise, display "Invalid Time".
    //If the user doesn't provide any values, consider it as invalid time. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz godzine w formacie 'hh:mm'. Zobaczymy, czy ci sie uda. ;)");
            var input = Console.ReadLine();
            var znaki = new Char[5]; 
            var error = "Nieprawidłowy format godziny!";
            var sukces = "Udalo sie wprowadzic godzine w poprawnym formacie!";
            #region Scenariusze testowe
            //var input = string.Empty;
            //var testPozytywny1 = "00:00";
            //var testPozytywny2 = "09:59";
            //var testPozytywny3 = "12:44";
            //var testNegatywny1 = "";
            //var testNegatywny2 = "5:11";
            //var testNegatywny3 = "5.33";
            //var testNegatywny4 = "25:00";
            //var testNegatywny5 = ".23:70"; 
            //input = testNegatywny5;
            #endregion
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(error);
                return;
            }

            if (input.Length != 5)
            {
                Console.WriteLine(error);
                return;
            }
            input.CopyTo(0, znaki, 0, 5);
            var godzina1 = Convert.ToInt16(znaki[0]);
            //var godzina2 = Convert.ToByte(znaki[1]);
            var calaGodzina = Convert.ToInt16(input.Substring(0, 2));
            var minuta1 = Convert.ToInt16(znaki[3]);
            //var minuta2 = Convert.ToByte(znaki[4]);
            var minutyCale = Convert.ToInt16(input.Substring(3, 2));
            if (godzina1 >= 0 && godzina1 <= 2 && calaGodzina >= 0 && calaGodzina <=23)
            {
                if (znaki[2] == ':')
                {
                    if (minuta1 >= 0 && minuta1 <= 5 && minutyCale >= 0 && minutyCale <60)
                    {
                        Console.WriteLine(sukces);
                    }
                }
            }
            else
            {
                Console.WriteLine(error);
            }
        }
    }
}
