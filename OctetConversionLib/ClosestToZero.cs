using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class ClosestToZero
    {
        public int Compute(int[]? ints)
        {
            var res = 0;
            if (ints?.Length > 0)
            {
                Array.Sort(ints);
                List<int> neg = new();
                List<int> pos = new();

                foreach (var num in ints)
                {
                    if (num < 0)
                    {
                        neg.Add(num);
                    }
                    else
                    {
                        pos.Add(num);
                    }
                }
                if (neg.Count == 0)
                {
                    res = pos[0];
                }
                else if (pos.Count == 0)
                {
                    res = neg[^1];
                }
                else
                {
                    res = pos[0] <= Math.Abs(neg[^1]) ? pos[0] : neg[^1];
                }
            }
            return res;
        }

    }
}
