using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class SpringSoldes
    {
        public static int CalculateTotalPrice(int[] prices, int discount)
        {
            decimal maxPrice = prices.Max(p);
            decimal total = prices.Sum();
            decimal discnt = maxPrice * (discount / 100m);
            return (int)Math.Floor(total - discnt);
            //return (int)(total - discnt);
        }

    }
}
