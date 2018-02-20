using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_4
{
    //4- Write a program and ask the user to enter a few words separated by a space.
    //Use the words to create a variable name with PascalCase.
    //For example, if the user types: "number of students", display "NumberOfStudents". 
    //Make sure that the program is not dependent on the input.
    //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz parę słó oddzielając je spacją. Ja zamienię je wszystkie na wyrażenie z zastosowaniem PascalCase");
            var input = Console.ReadLine();

            //var input = string.Empty;
            //var test1 = "pierwsze drugie trzecie czwarte";
            //var test2 = "  pierwsze drugie trzecie czwarte  ";
            //var test3 = "PI HGKJGH LKGHKJHG LKHGLJGHKJgh lkjhlkh";
            //var testNegatywny1 = "123123123";
            //var testNegatywny2 = "1234 123 4123asdfasd4 asdfasdf 234 123 4";
            //input = test3;
            
            var wyrazyRazem = input.ToLower().Trim(' ').Split(' ');

            foreach (var wyraz in wyrazyRazem)
            {
                if (!wyraz.All(Char.IsLetter))
                {
                    Console.WriteLine("Oczekiwałem wyrazów składających się wyłącznie z liter... Narka...");
                    return;
                }
            }

            foreach (var VARIABLE in wyrazyRazem)
            {
                var pierwszaLitera = VARIABLE.First().ToString().ToUpper();
                var bezPierwszejLitery = VARIABLE.Remove(0, 1);
                Console.Write(string.Concat(pierwszaLitera,bezPierwszejLitery));
            }
            Console.WriteLine();


        }
    }
}
