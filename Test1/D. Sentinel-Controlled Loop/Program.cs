using System;
using static System.Console;

namespace D._Sentinel_Controlled_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int nonZro = 0, nonZroSum = 0, contigSumMax = 0;
            Boolean same = false, zero;
            Write("Enter number: ");
            int prev = int.Parse(ReadLine());
            int realPrev = 0; if (prev != 0) { realPrev = prev; nonZro++; nonZroSum += prev; }
            while (!same)
            {
                Write("Enter number: ");
                int input = int.Parse(ReadLine());

                if (input != 0) { nonZro++; nonZroSum += input; }

                if (input == 0 || prev == 0) { zero = true; } else { zero = false; }

                if (input > 0 && realPrev > 0 || input < 0 && realPrev < 0)
                {
                    same = true;
                    continue;
                }

                if (!zero)
                {
                    int contig = prev + input;
                    //WriteLine(contig);
                    if (Math.Abs(contig) > contigSumMax) { contigSumMax = contig; }
                }

                prev = input;
                if (prev != 0) { realPrev = prev; }
            }
            WriteLine($"The average is {nonZroSum} / {nonZro} = {(double)nonZroSum / (double)nonZro}. The largest contiguous sum is {contigSumMax}.");
        }
    }
}
