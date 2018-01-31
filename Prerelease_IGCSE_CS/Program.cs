using System;
using System.Collections.Generic;
using System.Linq;

namespace Prerelease_IGCSE_CS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the computer ordering system!");
            while (true)
            {
                Console.WriteLine("Press O to place an order. Press any other key to end the day's transactions.");
                if (char.ToLower(Console.ReadKey().KeyChar) == 'o')
                {
                    Console.WriteLine();
                    PrintSeparator();
                    var estimate = GetEstimate();
                    PrintSeparator();
                    Console.WriteLine(estimate);
                    PrintSeparator();
                    if (estimate.Choices.All(x => Stock.InStock(x))) {
                        Console.WriteLine("All the selected components are in stock. Press C to confirm the order, or any other key to cancel.");
                        if (char.ToLower(Console.ReadKey().KeyChar) == 'c') {
                            Console.WriteLine();
                            Console.WriteLine("Please enter your name.");
                            var name = Console.ReadLine();
                            Stock.Purchase(estimate.Choices);
                            var order = new Order(name, estimate);
                            Console.WriteLine("Order has been made successfully.");
                        }
                    } else {
                        Console.WriteLine("One or more components requested is out of stock. Please try other components.");
                        continue;
                    }
                } else {
                    Console.WriteLine();
                    break;
                }
            }
            PrintReport();
        }

        // Task 1 Completed
        static Estimate GetEstimate()
        {
            var choices = new List<Choice>();
            foreach (var component in Choice.ChoiceDictionary) 
            {
                Console.WriteLine($"Please select a {component.Key}:");
                int i = 1;
                foreach (var choice in component) 
                {
                    Console.WriteLine($"{i}. {choice.Name} ${choice.Price}");
                    i++;
                }
                var chosen = component.ElementAt(Convert.ToInt32(Console.ReadLine()) - 1);
                choices.Add(chosen);
            }
            return new Estimate(choices);
        }
        }
    }
}
