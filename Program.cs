using System;

namespace HackersRank
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPairsInList fa = new FindPairsInList();
            Console.WriteLine(fa.FindPairs(9, new int[] { 10, 20 ,20, 10 ,10 ,30 ,50, 10, 20 }));
            Console.Read();
        }
    }
}
