using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            Console.WriteLine($"{a} - {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a} - {b}");
        }
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
