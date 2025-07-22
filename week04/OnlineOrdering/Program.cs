using System;

public class Program
{
    public static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 800.0, 1));
        order1.AddProduct(new Product("Mouse", 102, 20.0, 2));

        // Second Order
        Address address2 = new Address("456 King Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mohamed Ahmed", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 500.0, 1));
        order2.AddProduct(new Product("Earphones", 202, 30.0, 2));
        order2.AddProduct(new Product("Charger", 203, 25.0, 1));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
