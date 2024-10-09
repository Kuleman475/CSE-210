using System;
class Product {

    private string _nameOfProduct {get; set;}
    private int _productID {get; set;}
    private double _price {get; set;}
    private int _quantity {get; set;}

    public Product(string nameofProduct, int productId, double price, int quantity){
        _nameOfProduct = nameofProduct;
        _productID = productId;
        _price = price;
        _quantity = quantity;
    }
    public void Total(){
        double total = _price * _quantity;
        Console.WriteLine($"Total cost = ${total}");
    }
// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. 
// (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)


}