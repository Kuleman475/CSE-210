using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------");
        List<Product> _customerProducts = new List<Product>();
        Address address1 = new Address("1234 State street", "Raliegh", "NC", "USA");
        Customer customer1 = new Customer("Sarah", address1);
        Product product1 = new Product("twix", 452, 0.50, 3);
        Product product2 = new Product("Apples", 226, 0.25, 12);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        double sub = order1.Subtotal();
        double ship = order1.ShippingCost(address1);
        order1.PackingLabel();
        Console.WriteLine("");
        order1.ShippingLabel(customer1);
        Console.WriteLine("");
        order1.OrderTotal(sub, ship);
   

        Console.WriteLine("----------------------------");
        List<Product> _customerProducts2 = new List<Product>();
        Address address2 = new Address("3 4th st", "Paris", "France", "EUR");
        Customer customer2 = new Customer("Remi", address2);
        Product product3 = new Product("Red Pepper", 32587, 4.26, 8);
        Product product4 = new Product("Olives", 78944, 0.99, 6);
        Product product5 = new Product("Tomatoe", 78912, 2.09, 45);
        Order order2 = new Order(customer1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        double sub2 = order2.Subtotal();
        double ship2 = order2.ShippingCost(address2);
        order2.PackingLabel();
        Console.WriteLine("");
        order2.ShippingLabel(customer2);
        Console.WriteLine("");
        order2.OrderTotal(sub2, ship2);

        Console.WriteLine("----------------------------");
        List<Product> _customerProducts3 = new List<Product>();
        Address address3 = new Address("4560 Main st", "Dallas", "TX", "USA");
        Customer customer3 = new Customer("Big Tex", address3);
        Product product7 = new Product("Brisket", 32587, 5, 10);
        Product product8 = new Product("Hamburger", 78944, 2.99, 16);
        Product product9 = new Product("Buns", 78912, 1.50, 6);
        Order order3 = new Order(customer3);
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.AddProduct(product9);
        double sub3 = order3.Subtotal();
        double ship3 = order3.ShippingCost(address3);
        order3.PackingLabel();
        Console.WriteLine("");
        order3.ShippingLabel(customer3);
        Console.WriteLine("");
        order3.OrderTotal(sub3, ship3);
   
    }

}