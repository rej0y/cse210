using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            street: "123 Main St",
            city: "Rexburg",
            stateOrProvince: "ID",
            country: "USA"
        );

        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product(
            name: "Laptop",
            id: "P100",
            pricePerUnit: 1000,
            quantity: 2
        );

        Product product2 = new Product(
            name: "Mouse",
            id: "P200",
            pricePerUnit: 25,
            quantity: 3
        );

        Order order1 = new Order(new List<Product>([product1, product2]), customer1);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine($"Total Price ${order1.CalculateTotalCost():F2}");
    }
}