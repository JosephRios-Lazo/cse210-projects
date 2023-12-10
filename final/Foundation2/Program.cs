using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("456 Beach Road", "Playa del Carmen", "Quintana Roo", "Mexico");
        Customer customer1 = new Customer("Carlos Rodriguez", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Beach Towel", "BT789", 15.99, 2);
        Product p1002 = new Product("Sunglasses", "SG101", 29.99, 1);
        Product p1003 = new Product("Portable Fan", "PF202", 19.99, 3);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("123 Main Street", "Springfield", "IL 62701", "USA");
        Customer customer2 = new Customer("Alice Johnson", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Smart Watch", "SW123", 89.99, 2);
        Product p2002 = new Product("Wireless Earbuds", "WE456", 49.99, 1);
        Product p2003 = new Product("Portable Charger", "PC789", 29.99, 3);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("456 Oak Avenue", "Greenville", "SC 29601", "USA");
        Customer customer3 = new Customer("Robert Davis", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Laptop Backpack", " LB101", 59.99, 1);
        Product p3002 = new Product("Bluetooth Speaker", "BS202", 39.99, 2);
        Product p3003 = new Product("Fitness Tracker", "FT303", 79.99, 1);

        productsList3.Add(p3001);
        productsList3.Add(p3002);
        productsList3.Add(p3003);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}