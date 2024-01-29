using System;

namespace OrderIdsAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] fraudulentOrdersIds = new string[3];
            fraudulentOrdersIds[0] = "A123";
            fraudulentOrdersIds[1] = "B456";
            fraudulentOrdersIds[2] = "C789";
            //fraudulentOrdersIds[3] = "D101";
            */

            string[] fraudulentOrdersIds = { "A123", "B456", "C789" };
            //Accessing the values in the array.

            Console.WriteLine($"First: {fraudulentOrdersIds[0]}");
            Console.WriteLine($"Second: {fraudulentOrdersIds[1]}");
            Console.WriteLine($"Third: {fraudulentOrdersIds[2]}");

            //Reassigning a value to an index of the array
            fraudulentOrdersIds[0] = "F000";

            Console.WriteLine($"There are {fraudulentOrdersIds.Length} fraudulent orders to be processes");
            Console.WriteLine($"Reassign First: {fraudulentOrdersIds[0]}");


            string[] names = { "Rowena", "Robin", "Bao" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
