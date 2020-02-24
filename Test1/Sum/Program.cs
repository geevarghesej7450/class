using System;
using static System.Console;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inc = 2, sum = 0, x = 1;
            for(int i = 1; i <= 100; i+=inc){
                if (i != 1) { Write(" + "); }
                Write($"{i}");
                sum += i;

                if (x % 2 == 0)
                {
                    inc = 3;
                }
                else
                {
                    inc = 2;
                }
                x++;
            }
            Write($" = {sum}");
        }
    }
}
