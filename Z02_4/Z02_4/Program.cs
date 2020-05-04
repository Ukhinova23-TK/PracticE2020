using System;

namespace Z02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for(int i=1; i<=5; i++)
            {
                n = i;
                for(int j=1; j<=i; j++)
                {
                    Console.Write(n + " ");
                    n--;
                }
                Console.Write('\n');
            }
            Console.ReadKey();
        }
    }
}
