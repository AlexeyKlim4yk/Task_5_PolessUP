using System;

namespace Task_5_PolessUP
{
    class Program
    { 
        static int Max(int[] mass)
        {
            int max = mass[0];
            foreach (int x in mass)
            {
                if (x > max) max = x;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] mass = new int[5] { 234, -14, 2, 41, 4 };
            Console.WriteLine(Max(mass));
        }
    }
}
