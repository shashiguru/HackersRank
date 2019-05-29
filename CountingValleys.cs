using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class CountingValleys
    {
        public int FindNoOfValleys(int n, string s)
        {
            int count = 0;
            int result = 0;
            char[] charar = s.ToCharArray();
            foreach (char item in charar)
            {
                switch (item)
                {
                    case 'U':
                        {
                            if (count < 0)
                            {
                                count++;
                                if (count == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                            continue;
                        }

                    case 'D':
                        {
                            count--;
                            continue;
                        }
                        
                }
            }
            return result;
        }
    }
}
