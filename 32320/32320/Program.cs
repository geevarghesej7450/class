using System;

namespace _32320
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 277777788888989;
            long[] p = new long[15];
            Console.WriteLine($"other ans {Presistence(n,ref p)} and {n:N0}");

            //int pres = 0;

            //long prod = 1;

            //int count = 0;

            //while (n > 0)
            //{
            //    foreach(char c in n.ToString())
            //    {
            //        Console.WriteLine(prod);
            //        prod *= (int)c;
            //    }
            //    n = prod;
            //    count++;
            //}

            //pres = 1 + count;

            //Console.WriteLine($"smallest prime is {pres} and {n:N0}");
            
        }

        static int Presistence(long n)
        {
            if (n < 0) { n = -n; }
            else if (n < 10) { return 0; }

            long product = 1;
            while (n > 0)
            {
                long digit = n % 10;
                n = n / 10;
                product *= digit;
            }
            int count = 1 + Presistence(product);
            return count;
        }

        static int Presistence(long n, ref long[] products)
        {
            if (n < 0) { n = -n; }
            else if (n < 10) { return 0; }

            long product = 1;
            int x = 0;
            while (n > 0)
            {
                long digit = n % 10;
                n = n / 10;
                product *= digit;
                products[x] = product;
                x++;
            }
            int count = 1 + Presistence(product);
            return count;
        }

        static void Replace(ref long[] arry, long value)
        {
            int firstZero = 0; Boolean change = false;
            for(int i = 0; i < arry.Length; i++)
            {
                if (arry[i] == 0)
                {
                    firstZero = i;
                    change = true;
                    continue;
                }
            }
            if (change)
            {
                arry[firstZero] = value;
            }
            else
            {
                Console.WriteLine("No zeros");
            }
        }
    }
}
