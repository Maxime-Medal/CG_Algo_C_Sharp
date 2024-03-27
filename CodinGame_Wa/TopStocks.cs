using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class TopStocks
    {
        public string[] GetTopStocks(string[] stocks, float[,] prices) // prices [3,6]
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.WriteLine($"length_0: {prices.GetLength(0)}");
            Console.WriteLine($"length_1: {prices.GetLength(1)}");

            // dans la liste de stocks on selectionne la clé et on prend l'index pour l'ulitiser ensuite
            var dictionnary = stocks.Select((key, index) =>
            {
                // création d'un tableau de la longueur = première dimension
                var row = new float[prices.GetLength(0)];

                // on boucle sur la prenière dimension du tablea
                for (int i = 0; i < prices.GetLength(0); i++)
                {
                    // on récupère la valeur dans la 2ieme dimension qui correspond à l'index de la clé
                    row[i] = prices[i, index];
                }

                // on crée l'ensemble clé/valeur qui correspond au prix moyen
                return new
                {
                    Key = key,
                    Value = row.Sum(x => x) / prices.GetLength(0)
                };
            }).ToDictionary(item => item.Key, item => item.Value);

            // affichage des clés/valeurs
            foreach (var item in dictionnary.OrderBy(c => c.Value))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }

            // on tri le dictionnaire par ordre décroissant comme demandé et on prend les 3 premiers
            var res = dictionnary.OrderByDescending(c => c.Value).Take(3);
            foreach (var item in res)
            {
                Console.WriteLine(item.Key);
            }

            return res.Select(r => r.Key).ToArray();
        }

        public string[] GetTopStocks2(string[] stocks, float[,] prices) // prices [3,6]
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.WriteLine($"length_0: {prices.GetLength(0)}");
            Console.WriteLine($"length_1: {prices.GetLength(1)}");

            // dans la liste de stocks on selectionne la clé et on prend l'index pour l'ulitiser ensuite
            var dictionary = stocks
                .Select((stock, index) =>
                new
                {
                    Key = stock,
                    Value = Enumerable
                    .Range(0, prices.GetLength(0))
                    .Select(row => prices[row, index])
                    .ToArray()
                }
            )
                .ToDictionary(item => item.Key, item => item.Value.Sum()/ prices.GetLength(0));

            // affichage des clés/valeurs
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }

            //// on tri le dictionnaire par ordre décroissant comme demandé et on prend les 3 premiers
            var res = dictionary.OrderByDescending(c => c.Value).Take(3);
            foreach (var item in res)
            {
                Console.WriteLine(item.Key);
            }

            return res.Select(r => r.Key).ToArray();
        }
    }
}
