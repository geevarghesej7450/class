using System;
using static System.Console;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 29; i >= -10; i -= 3) 
            {
                if (i != 29) { Write(", "); }
                Write($"{i}");
            }
        }
    }
}
