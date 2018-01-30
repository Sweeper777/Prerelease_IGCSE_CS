using System;
using System.Collections.Generic;
using System.Linq;
namespace Prerelease_IGCSE_CS
{
    public static class Stock
    {
        public static readonly Dictionary<Choice, int> AllStock;

        static Stock() 
        {
            var r = new Random();
            AllStock = Choice.AllChoices.ToDictionary(x => x, x => r.Next(100));
        }

        public static bool InStock(Choice choice) => AllStock[choice] > 0;

        public static void Purchase(List<Choice> choices)
        {
            if (choices.Any(x => !InStock(x))) {
                throw new ArgumentException("One or more components are not in stock!");
            }

            choices.ForEach(x => AllStock[x] -= 1);
        }
    }
}
