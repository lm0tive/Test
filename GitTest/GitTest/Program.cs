using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "Hello";
            string w = "World";
            char i = '!';
            int a = 2;
            int b = 4;

            Console.WriteLine($"{h} {w}{i}");

            int c = a * b;

            Console.Write($"{c}");

            Console.ReadKey();



        }    
    }
}
