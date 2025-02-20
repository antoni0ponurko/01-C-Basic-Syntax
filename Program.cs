// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dict_aankopen = new Dictionary<string, List<int>>
        {
            { "jan", new List<int> { 100, 50, 20 } },
            { "piet", new List<int> { 10, 70, 20, 4, 58, 542 } },
            { "karel", new List<int> { 9 } },
            { "sandra", new List<int> { 45, 45, 10 } }
        };

        int threshold = 200;
        var expensiveCustomers = GetExpensiveShoppingBaskets(dict_aankopen, threshold);

        Console.WriteLine("The following individuals had a shopping cart value higher than € " + threshold + ":");
        foreach (var customer in expensiveCustomers)
        {
            Console.WriteLine("- " + customer);
        }
    }

    static List<string> GetExpensiveShoppingBaskets(Dictionary<string, List<int>> purchases, int threshold)
    {
        List<string> result = new List<string>();
        foreach (var customer in purchases)
        {
            int total = 0;
            foreach (var amount in customer.Value)
            {
                total += amount;
            }
            if (total > threshold)
            {
                result.Add(customer.Key);
            }
        }
        return result;
    }
}

