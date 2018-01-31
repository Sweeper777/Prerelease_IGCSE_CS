using System;
using System.Collections.Generic;
using System.Linq;

namespace Prerelease_IGCSE_CS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Task 2 Completedad
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
                            PrintSeparator();
                            Console.WriteLine(order);
                            PrintSeparator();

                        } else {
                            Console.WriteLine();
                            Console.WriteLine("Order canceled");
                            PrintSeparator();
                            continue;
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
        static void PrintReport() {
            PrintSeparator();
            Console.WriteLine("End of Day Report");
            PrintSeparator();
            var allOrdersToday = Order.AllOrders.Where(x => x.Date == DateTime.Today).ToList();
            Console.WriteLine($"Number of orders: {allOrdersToday.Count}");
            Console.WriteLine("Components Sold:");
            var componentsSold = allOrdersToday.SelectMany(x => x.EstimateDetails.Choices)
                                               .GroupBy(x => x)
                                               .ToDictionary(x => x.Key.ToString(), x => x.Count());
            foreach (var kvp in componentsSold) {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            var totalValue = allOrdersToday.Aggregate(0m, (x, y) => x + y.EstimateDetails.Price);
            Console.WriteLine($"Total Value: ${totalValue}");
        }

        static void PrintSeparator() {
            Console.WriteLine("-------------------");
        }
    }
}
