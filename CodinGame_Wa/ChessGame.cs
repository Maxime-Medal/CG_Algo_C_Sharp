using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class ChessGame
    {
        /// Counts the number of pairs for n players.
        public static int Count(int n)
        {
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountBis(int n)
        {

            return (n * (n - 1) / 2);
        }

    }
}
