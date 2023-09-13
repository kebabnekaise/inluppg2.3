using System;

namespace inluppg2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int startavgift = 300;
            int krpkm = 1;
            int prisPerDag = 500;

            Console.WriteLine("Hur många dagar tänker du hyra?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur lång tänker du köra?");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine($"Det kommer att kosta dig {startavgift + (dagar-1)*prisPerDag + km*krpkm}:-");
        }
    }
}