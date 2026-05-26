using System;

class Program
{
    static void Main(string[] args)
    {
        
        // order1 customer in USA
        
        
        Address address1  = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-204", 29.99, 2));
        order1.AddProduct(new Product("USB-C Hub", "UC-887", 49.99, 1));
        order1.AddProduct(new Product("Laptop Stand", "LS-113", 34.99, 1));
        
        
        // order2 customer not in USA
        
        
        Address address2  = new Address("10 Ave de Verdun", "Paris", "France", "FRA");
        Customer customer2 = new Customer("François Lacroix", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-560", 89.99, 1));
        order2.AddProduct(new Product("Monitor Light Bar", "ML-321", 39.99, 2));
        
        
        // order3 other customer in USA
        
        
        Address address3  = new Address("221B Baker Street", "Salt Lake City", "UT", "USA");
        Customer customer3 = new Customer("Emma Watkins", address3);
        
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Desk Organizer", "DO-445", 19.99, 3));
        order3.AddProduct(new Product("Blue Light Glasses", "BG-077", 24.99, 1));
        order3.AddProduct(new Product("Cable Management Kit", "CM-902", 14.99, 2));
        
        
        // display all orders
        
        
        List<Order> orders = new List<Order>() { order1, order2, order3 };
        
        foreach (Order order in orders)
        {
            Console.WriteLine("============================================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice():F2}");
            Console.WriteLine();
        }
    }
}