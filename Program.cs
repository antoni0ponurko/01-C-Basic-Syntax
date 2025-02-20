// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the price of the construction land: ");
        double landPrice;
        while (!double.TryParse(Console.ReadLine(), out landPrice) || landPrice < 0)
        {
            Console.Write("Please enter a valid non-negative number: ");
        }

        Console.Write("Enter the price of the building: ");
        double buildingPrice;
        while (!double.TryParse(Console.ReadLine(), out buildingPrice) || buildingPrice < 0)
        {
            Console.Write("Please enter a valid non-negative number: ");
        }

        double totalCost = (landPrice + buildingPrice) * 1.21;

        Console.WriteLine($"The total cost of the project, including a 21% charge, is: {totalCost:F2} EUR");
    }
}
