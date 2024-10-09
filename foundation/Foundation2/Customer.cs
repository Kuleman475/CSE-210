using System;

class Customer{

    private string _name;

    public Address _address;

    public Customer(string name, Address address){
        
        _name = name;
        _address = address;
    }
    public void DisplayCustomer(){
        Console.WriteLine($"CUSTPMEWE: {_name}, ADDRESS: {_address}");
    }

// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. 
// (Hint this should call a method on the address to find this.)
}