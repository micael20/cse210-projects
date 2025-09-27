using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address internationalAddress = new Address("382 Royal Soap St", "Dar Es SAlaam", "DSM", "Tanzania");

        // Create customers
        Customer customer1 = new Customer("Michael Mwodete", usaAddress);
        Customer customer2 = new Customer("Frank Castello", internationalAddress);

        // Create products
        Product product1 = new Product("Laptop", "P1001", 999.99, 1);
        Product product2 = new Product("Mouse", "P1002", 25.50, 2);
        Product product3 = new Product("Keyboard", "P1003", 75.00, 1);
        Product product4 = new Product("Monitor", "P1004", 299.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product2); 

        // Display order details
        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"TOTAL COST: ${order.CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}
    }
