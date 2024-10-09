using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 State street", "Raliegh", "NC", "USA");
        Customer customer = new Customer("Sarah", address1);
        Product product = new Product("twix", 452, 0.50, 3);
        Order order = new Order(customer);
        product.Total();
        
        customer.DisplayCustomer();
        address1.AddressString();
        
        Console.WriteLine(address1.IsUSA());
    }
}