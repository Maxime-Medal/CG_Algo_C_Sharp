using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class WordsFrequencies
    {
        public int[] CountFrequencies(string[] words)
        {
            Array.Sort(words);
            var distinctWord = words.Distinct().OrderBy(c => c).ToList();
            List<int> res = new();
            for (var i = 0; i < distinctWord.Count(); i++)
            {
                var n = words.Where(w => w == distinctWord[i]).Count();
                res.Add(n);
            }
            foreach (var item in res) {
                Console.Write($"{item}, ");
            }
            return res.ToArray();
        }
    }
}
