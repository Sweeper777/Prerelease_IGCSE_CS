using System;
using System.Collections.Generic;

namespace Procedural_Solution
{
    class MainClass
    {
        
        static IReadOnlyList<string> processorChoices = new List<string> { "p3", "p5", "p7" }.AsReadOnly();
        static IReadOnlyList<int> processorPrices = new List<int> { 100, 120, 200 }.AsReadOnly();

        static IReadOnlyList<string> ramChoices = new List<string> { "16GB", "32GB" }.AsReadOnly();
        static IReadOnlyList<int> ramPrices = new List<int> { 75, 150 }.AsReadOnly();

        static IReadOnlyList<string> storageChoices = new List<string> { "1TB", "2TB" }.AsReadOnly();
        static IReadOnlyList<int> storagePrices = new List<int> { 50, 100 }.AsReadOnly();

    }
}
