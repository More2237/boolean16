using System;
using static System.Console;

namespace boolean16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            bool b = a>9 && a<100 && a % 2 == 0;
            WriteLine(b);
        }
    }
}