using System;

namespace SalesTaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirmation;
            double doubleCost;
            double totalCost = 0;
            double salesTax = 0;
            double totalAfterTax = 0;
            Console.WriteLine("Sales Tax Calculator\n");
            do
            {
                Console.WriteLine("ENTER ITEMS (ENTER 0 TO END)");
                do
                {
                    Console.Write("Cost of items: ");
                    string cost = Console.ReadLine();
                    doubleCost = Convert.ToDouble(cost);
                    totalCost = totalCost + doubleCost;
                    salesTax = (totalCost *.06);
                    totalAfterTax = (totalCost + salesTax);
                }
                while (doubleCost > 0);
                Console.WriteLine("Total\t\t\t" + Math.Round(totalCost,2));
                Console.WriteLine("Sales Tax\t\t" + Math.Round(salesTax,2));
                Console.WriteLine("Total After Tax\t\t" + Math.Round(totalAfterTax,2));
                    Console.Write("Again? (y/n)");
                    confirmation = Console.ReadLine();
                totalCost = 0;
                salesTax = 0;
                totalAfterTax = 0;
            }
            while (confirmation.ToLower() == "y");
            Console.WriteLine("Thanks, bye!");
        }
    }
}
