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

        static IReadOnlyList<string> screenChoices = new List<string> { "19\"", "23\"" }.AsReadOnly();
        static IReadOnlyList<int> screenPrices = new List<int> { 65, 120 }.AsReadOnly();

        static IReadOnlyList<string> caseChoices = new List<string> { "Mini Tower", "Midi Tower" }.AsReadOnly();
        static IReadOnlyList<int> casePrices = new List<int> { 40, 70 }.AsReadOnly();

        static IReadOnlyList<string> usbChoices = new List<string> { "2 ports", "4 ports" }.AsReadOnly();
        static IReadOnlyList<int> usbPrices = new List<int> { 10, 20 }.AsReadOnly();
        static int processor;
        static int ram;
        static int storage;
        static int screen;
        static int @case;
        static int usb;
        static List<int> processorStock = new List<int> { 10, 10, 1 };
        static List<int> ramStock = new List<int> { 10, 10 };
        static List<int> storageStock = new List<int> { 10, 10 };
        static List<int> screenStock = new List<int> { 10, 10 };
        static List<int> caseStock = new List<int> { 10, 10 };
        static List<int> usbStock = new List<int> { 10, 10 };
        static List<int> processorSold = new List<int> { 0, 0, 0 };
        static List<int> ramSold = new List<int> { 0, 0 };
        static List<int> storageSold = new List<int> { 0, 0 };
        static List<int> screenSold = new List<int> { 0, 0 };
        static List<int> caseSold = new List<int> { 0, 0 };
        static List<int> usbSold = new List<int> { 0, 0 };
        static int nextID = 1;
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

                    processor = AskForChoice("processor", processorChoices, processorPrices);
                    ram = AskForChoice("RAM", ramChoices, ramPrices);
                    storage = AskForChoice("storage", storageChoices, storagePrices);
                    screen = AskForChoice("screen", screenChoices, screenPrices);
                    @case = AskForChoice("case", caseChoices, casePrices);
                    usb = AskForChoice("USB port count", usbChoices, usbPrices);

                    PrintSeparator();
                    PrintEstimate();
                    PrintSeparator();

                }
            }
        }

        static int AskForChoice(string componentName, IReadOnlyList<string> choices, IReadOnlyList<int> prices)
        {
            Console.WriteLine($"Please select a {componentName}:");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {choices[i]} - ${prices[i]}");
            }
            var retVal = Convert.ToInt32(Console.ReadKey().KeyChar.ToString()) - 1;
            Console.WriteLine();
            return retVal;
        }

        // Task 1 Completed
        static void PrintEstimate()
        {
            Console.WriteLine($"ID: {nextID}");
            Console.WriteLine("Components:");
            Console.WriteLine($"Processor: {processorChoices[processor]}");
            Console.WriteLine($"RAM: {ramChoices[ram]}");
            Console.WriteLine($"Storage: {storageChoices[storage]}");
            Console.WriteLine($"Screen: {screenChoices[screen]}");
            Console.WriteLine($"Case: {caseChoices[@case]}");
            Console.WriteLine($"USB Ports: {usbChoices[usb]}");

            var price = (
                processorPrices[processor] +
                ramPrices[ram] +
                storagePrices[storage] +
                screenPrices[screen] +
                casePrices[@case] +
                usbPrices[usb]
            ) * 1.2m;

            Console.WriteLine($"Price: ${price}");
        }

        static void PrintSeparator()
        {
            Console.WriteLine("-------------------");
        }
    }
}
