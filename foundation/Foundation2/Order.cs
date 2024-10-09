using System;

class Order {
    private List<Product> _customerProducts = new List<Product>();
    private Customer _customer {get; set;}

    public Order(Customer customer){
        _customer = customer;
    }
    public void AddProduct(Product product){
        _customerProducts.Add(product);
    }
    public double Subtotal(){
        double subtotal = 0;
        foreach (Product product in _customerProducts)
        {
            subtotal += product.Total();
        }
        return subtotal;
    }
    public double ShippingCost(Address address){
        if(address.IsUSA() == true){
            return 5;
        }
        else {
            return 35;
        }
    }
    public double OrderTotal(double subtotal, double shippingTotal){
        double orderTotal = subtotal + shippingTotal;
        Console.WriteLine($"Order Total: ${orderTotal}");
        return orderTotal;
    }
    // Shipping label name and address of the customer
    public void ShippingLabel(Customer customer){
        Console.WriteLine("Shipping Label");
        customer.DisplayCustomer();
    }

    //  packing label should list the name and product id of each product in the order.
    public void PackingLabel(){
        Console.WriteLine("Packing Label");
        foreach (Product product in _customerProducts)
        {
            product.Display();
        }
        

    }


}

// Order
// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. 
// Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
// If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer