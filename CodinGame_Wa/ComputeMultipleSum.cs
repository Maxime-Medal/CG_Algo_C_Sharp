using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class ComputeMultipleSum
    {
        public static int ComputeMultiplesSum(int n)
        {
            var res = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    res += i;
                }
            }

            return res;
        }
    }
}
