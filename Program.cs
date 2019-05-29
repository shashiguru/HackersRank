using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPairsInList fa = new FindPairsInList();
            fa.FindPairs(5, new int[] { 1, 2, 3, 1, 2 });
            CountingValleys cv = new CountingValleys();
            Console.WriteLine(cv.FindNoOfValleys(8, "UDDUUDDU") );
            Console.Read();
        }
    }
}
