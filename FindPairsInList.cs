using System;
using System.Collections.Generic;
using System.Text;

namespace HackersRank
{
   public class FindPairsInList
    {
        
        
        public int FindPairs(int n, int[] ar)
        {
            int result = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int item in ar)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item,0);
                }
            }
            foreach (int key in dict.Keys)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    
                    if (key==ar[i])
                    {
                        count++;
                    }
                }
                result =result+ count / 2;
                    
            }
            return result;
        }
    }
}
