using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    // Do not modify Change
    public class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;
        public long Total() => coin2 + bill5 + bill10;
        public long TotalCount() => coin2 * 2 + bill5 * 5 + bill10 * 10;
    }
    //class ChangeBis : Change
    //{
    //    public long Total() => coin2 + bill5 + bill10;
    //    public long TotalCount() => coin2 * 2 + bill5 * 5 + bill10 * 10;

    //}

    public static class ChangeCoin
    {

        // Do not modify this method​​​​​​‌​‌​‌‌‌‌​‌‌‌‌‌‌​​​​‌‌​‌​‌ signature
        public static Change OptimalChange(long s)
            {
            var res = new Change();
            decimal by10 = 0;
            decimal by5 = 0;
            decimal by2 = 0;
            decimal newS = s;
            decimal divBy10 = Math.Floor(s / 10m);
            decimal divBy5 = Math.Floor(s / 5m);
            decimal divBy2 = Math.Floor(s / 2m);

            for (long i = s; i == 0; i--)
            {

            }

            if (divBy10 > 0 || divBy5 > 0 || divBy2 > 0)
                Console.WriteLine("input : {0}", s);
            if (Math.Floor(newS / 10m) > 0)
            {
                res.bill10 = (int)Math.Floor(newS / 10m);
                newS = s - (res.bill10 * 10m);
                Console.WriteLine("if 10 :{0}", res.bill10 * 10m);
            }
            // rest = rest / 5;
            if (Math.Floor(newS / 5m) > 0)
            {
                res.bill5 = (int)Math.Floor(newS / 5m);
                newS = s - (res.bill5 * 5m) - (res.bill10 * 10m);
                Console.WriteLine("if 5 :{0}", newS);
            }
            if (Math.Floor(newS / 2m) > 0)
            {
                res.coin2 = (int)Math.Floor(newS / 2m);
                newS = newS - (res.bill5 * 5m) - (res.bill10 * 10m) - (res.coin2 * 2m);
                Console.WriteLine("if 2 :{0}", newS);
            }
            Console.WriteLine("=> Total: {0}", res.TotalCount());
            return s - res.TotalCount() == 0 ? res : null;
        }
    }
}
//La monnaie est correcte pour une somme de 10€
//La monnaie est optimale pour une somme de 10€ (1*10)
//<code>null</code> est retourné quand la somme vaut 1
//Le programme rend correctement la monnaie quand la somme vaut 31
//La monnaie est optimale pour une somme de 31€ (2*10 +5 + 3*2)
//<code>null</code> est retourné quand la somme vaut 3
//Le programme rend correctement la monnaie quand la somme vaut 8 (4 * 2)
//Résultat correct et dans les temps avec 9223372036854775802€
//Résultat correct et dans les temps avec 9223372036854775803€
//La monnaie est optimale avec 9223372036854775803€
