using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class BoundingRectangle
    {
        public static List<int> Compute(List<List<int>> cpts)
        {
            var minX = cpts.Min(c => c[0]);
            var minY = cpts.Min(c => c[1]);
            var maxX = cpts.Max(c => c[0]);
            var maxY = cpts.Max(c => c[1]);

            return new List<int>() { minX, minY, maxX - minX, maxY - minY };
        }

    }
}
