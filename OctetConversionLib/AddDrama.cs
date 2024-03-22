using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class AddDrama
    {
        // TODO gérer le test 7
        public string AddDramaChar(string text)
        {
            var newStr = new StringBuilder();

            // TODO implémenter le test 7
            //for (int i = 0; i < text.Length; i++)
            //{
            //    var actualChar = text[i];
            //    if (text[i] == '!' )
            //    {
            //        var test = text[i+1];
            //        if (test != '!')
            //        {
            //            newStr.Append('!');
            //        }
            //    }
            //    else if (text[i] == '.')
            //    {
            //        newStr.Append('!');
            //    }
            //    else
            //    {
            //        newStr.Append(actualChar);
            //    }
            //}
            //return newStr.ToString();

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