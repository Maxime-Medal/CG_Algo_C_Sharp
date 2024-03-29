using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class atomeGrid
    {
        public static List<string> Solve(int ps, int ns, int pt, int nt)
        {
            var n = "NEUTRON";
            var p = "PROTON";
            var a = "ALPHA";
            List<string> res = new();

            if (pt < ps || nt < ns)
            {
                var diffP = ps - pt;
                var diffN =ns - nt;
                decimal maxValue = Math.Max(diffN, diffP);
                var diviseur = Math.Round(maxValue / 2);
                for (int i = 0; i <= diviseur; i++)
                {
                    res.Add(a);
                    ps -= 2;
                    ns -= 2;
                }
            }

            if (pt > ps)
            {
                for (int i = 0; i < pt - ps; i++)
                {
                    res.Add(p);
                }
            }
            if (nt > ns)
            {
                for (int i = 0; i < nt - ns; i++)
                {
                    res.Add(n);
                }
            }

            return res;
        }

    }
}
