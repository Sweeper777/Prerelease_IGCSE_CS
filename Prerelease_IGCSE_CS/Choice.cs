using System;
using System.Collections.Generic;
using System.Linq;
namespace Prerelease_IGCSE_CS
{
    public class Choice
    {
        public string ComponentName { get; }
        public string Name { get; }
        public int Price { get; }

        Choice(string componentName, string name, int price)
        {
            ComponentName = componentName;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ComponentName} - {Name}";
        }

    }
}
