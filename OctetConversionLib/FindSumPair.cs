using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class FindSumPair
    {
        public List<int> FindPair(List<int> n, int k)
        {
            List<int> arr = new();
            for (int i = 0; i < n.Count(); i++)
            {
                for (int j = i + 1; j < n.Count(); j++)
                {
                    if (n[i] + n[j] == k)
                    {
                        arr.Add(i);
                        arr.Add(j);
                    }
                }
            }
            if(arr.Count > 2)
            {
                // On prend que les index pair et on en fait des tuples
                var pairs = arr.Where((x, i) => i % 2 == 0).Select((x, i) => new[] {x, arr[i + 1]}).ToList();
                pairs.OrderBy(x => x[0]);
                arr = pairs[0].ToList();
            }
            if (arr.Count == 0) arr= new List<int>() {0, 0};
            return arr;
        }

    }
}

//[0, 0] doit être retourné si aucune paire n'est trouvée.

//Dans le cas où il existe plusieurs paires possibles dont la somme est égale à la cible,
//retournez la paire dont l'indice de gauche est le plus bas.

//Dans le cas de deux paires ayant le même indice de gauche,
//privilégiez la paire dont l'indice de droite est le plus bas.
