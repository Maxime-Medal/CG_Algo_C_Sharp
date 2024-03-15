using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class AddDrama
    {
        public static string AddDramaa(string text)
        {
            var sArr = text.Split(' ');
            List<string> res = new();
            foreach (var s in sArr)
            {
                var newS = s;
                if (s.EndsWith('!'))
                {
                    newS = s.Insert(s.Length - 1, "!");
                }
                if (s.Contains('.'))
                {
                    newS = s.Replace('.', '!');
                }
                res.Add(newS);
            }
            return String.Join(' ', res);
        }

    }
}
