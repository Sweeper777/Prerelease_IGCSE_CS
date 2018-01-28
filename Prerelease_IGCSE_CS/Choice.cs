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

        public static readonly List<Choice> AllChoices = new List<Choice> {
            new Choice("Processor", "p3", 100),
            new Choice("Processor", "p5", 120),
            new Choice("Processor", "p7", 200),
            new Choice("RAM", "16GB", 75),
            new Choice("RAM", "32GB", 150),
            new Choice("Storage", "1TB", 50),
            new Choice("Storage", "2TB", 100),
            new Choice("Screen", "19\"", 65),
            new Choice("Screen", "23\"", 120),
            new Choice("Case", "Mini Tower", 40),
            new Choice("Case", "Midi Tower", 70),
            new Choice("USB Ports", "2 ports", 10),
            new Choice("USB Ports", "4 ports", 20),
        };
    }
}
