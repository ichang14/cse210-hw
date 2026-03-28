using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "Illinois", "USA");
        Address address2 = new Address("Av. Libertad 1234", "Viña del Mar", "Valparaíso", "Chile");
        Address address3 = new Address("1600 Pennsylvania Avenue NW", "Washington", "DC", "USA");
        Address address4 = new Address("Rua das Flores 89", "São Paulo", "SP", "Brasil");
        Customer customer1 = new Customer("John Stone", address1);
        Customer customer2 = new Customer("Ilich Chang", address2);
        Customer customer3 = new Customer("Emily Johnson", address3);
        Customer customer4 = new Customer("Ana Souza", address4);
        Product p1 = new Product("Laptop", 101, 800, 1);
        Product p2 = new Product("Mouse Gamer", 102, 25, 2);
        Product p3 = new Product("Lámpara LED", 104, 20, 3);
        Product p4 = new Product("Silla de Oficina", 105, 150, 1);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);
        Order order4 = new Order(customer4);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        order2.AddProduct(p1);
        order2.AddProduct(p2);
        order2.AddProduct(p3);

        order3.AddProduct(p4);
        order3.AddProduct(p2);
        order3.AddProduct(p3);

        order4.AddProduct(p4);
        order4.AddProduct(p2);
        order4.AddProduct(p3);

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"${order1.GetTotalCost()}");

        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"${order2.GetTotalCost()}");

        Console.WriteLine("Order 3");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"${order3.GetTotalCost()}");

        Console.WriteLine("Order 4");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"${order4.GetTotalCost()}");
    }
}