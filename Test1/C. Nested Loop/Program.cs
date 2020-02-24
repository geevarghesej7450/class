using System;
using static System.Console;

namespace C._Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, bits = 0;

            while (count < 5) 
            {
                Write("Enter number: ");
                int input = int.Parse(ReadLine());
                if (input > 0)
                {
                    count++;
                    while (input > 0)
                    {
                        bits++;
                        input /= 2;
                    }
                }
            }
            WriteLine($"Sum of bits is: {bits}");
        }
    }
}
