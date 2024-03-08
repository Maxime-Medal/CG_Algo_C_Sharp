using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class RangeSum
    {
        public int Calc(int[] array, int n1, int n2)
        {
            int res = 0;
            for (var i = n1; i <= n2; i++)
            {
                res += array[i];
            }

            return res;
        }

    }
}
