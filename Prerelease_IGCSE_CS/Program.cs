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
