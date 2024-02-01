using System;

namespace OrderIdsAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            /* //The following code creates five random OrderIDs to test the fraud detection process.
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
            int firstValue = 600;
            int secondValue = 450;
            int largerValue;

           largerValue =Math.Max(firstValue,secondValue);

            //string newMessage = new string(message);
            Console.WriteLine(largerValue);
            Console.WriteLine(message);
            Console.WriteLine($"'o' appears {letterCount} times."); 
            
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total =0;
            bool found;
            foreach (int number in numbers)
            {
                

                total += number;
              
                if (number == 42)
                {
                   found = true;
                    Console.WriteLine("Set contains 42");
                }
                
            }
         
            Console.WriteLine($"Total: {total}");
           
            var employeeLevel1 = Console.ReadLine();
            int employeeLevel = Convert.ToInt32(employeeLevel1);
            string employeeName = "John Smith";

            string title = "";
            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;

                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                default:
                    title = " Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");
            */
            // SKU = Stock Keeping Unit.
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";
            string[]product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";
            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }
            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }
            switch(product[2])
            {
                case "L":
                    size = "Large";
                    break;
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }
            Console.WriteLine($"Product: {size} {color} {type}");

        }
    }
}
