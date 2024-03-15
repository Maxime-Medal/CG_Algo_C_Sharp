using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class FindSomePair
    {
        public static List<int> FindPair(List<int> n, int k)
        {
            List<int> arr = new();
            for (int i = 0; i < n.Count(); i++)
            {
                for (int j = i + 1; j < n.Count(); j++)
                {
                    if (n[i] + n[j] == k)
                    {
                        arr.Add(i);
                        arr.Add(j);
                    }
                }
            }
            Console.WriteLine($"{arr}");
            return arr;
        }

    }
}
