using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class Annagram
    {
        public bool IsAnagram(string wordA, string wordB)
        {
            return wordA.ToLower().OrderBy(c => c).SequenceEqual(wordB.ToLower().OrderBy(b => b));
        }

    }
}
