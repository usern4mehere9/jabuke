using System;

namespace jabuke
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, m;
            p = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            if (p > m)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
