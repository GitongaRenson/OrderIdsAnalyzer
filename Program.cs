using System;

namespace OrderIdsAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             //The following code creates five random OrderIDs to test the fraud detection process.
            //OrderIds consist of a letter from A to E and a three digit number, Ex A123.
           
            Random random = new Random();
            string[] orderIDs = new string[5];
            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");
                orderIDs[i] = prefix + suffix;
            }
            foreach(var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

          
            string[] fraudulentOrdersIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            //Accessing the values in the array.
            foreach (string order in fraudulentOrdersIds)
            {
                if (order.StartsWith("B"))
                {
                    Console.WriteLine($"{order}");
                }
            }

            Console.WriteLine($"\nThere are {fraudulentOrdersIds.Length} fraudulent orders to be processes\n");
            
            
            string[] names = { "Rowena", "Robin", "Bao" };
           

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int bin = 0;
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"\nWe have {sum} items in the inventory\n");
       
            //This code reverses a message, counts the number of times a particular character appears, then prints the results to the console window.
            string originalMessage = "The quick brown fox jumps over the lazy dog.";
            char[] message = originalMessage.ToCharArray();
            //Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
             if (letter == 'o')
                {
                    letterCount++;
                }
            }
            //string newMessage = new string(message);
            Console.WriteLine(message);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }
    }
}
