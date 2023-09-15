using System;
namespace Uppgift_2.__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två decimaltecken som du vill multiplacera med varandra genom att bara ha ett gånger tecken mellan talen utan mellanslag..");
            string uttryck= Console.ReadLine();
            int gånger = uttryck.IndexOf("*");
            string tal1 = uttryck[..gånger];
            string tal2 = uttryck[(gånger + 1)..];
            double pro1 =double.Parse(tal1);
            double pro2 =double.Parse(tal2);
            Console.WriteLine(pro1 * pro2);
            Console.ReadKey();
        }
    }
}
