using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Sesame Street", "Sesame City", "California", "USA");
        Address address2 = new Address("7463 North St", "Kentville", "Nova Scotia", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        // Create products
        Product product1 = new Product("Candles", 7864, 24.99m, 5);
        Product product2 = new Product("Samsung Galaxy Phone", 1345, 768.98m, 1);
        Product product3 = new Product("Apples", 7567, 5.50m, 10);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
