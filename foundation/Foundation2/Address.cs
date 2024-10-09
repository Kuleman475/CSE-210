using System;
class Address {

    private string _street {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        
    }
    public void AddressString(){
        Console.WriteLine($"Address {_street}, {_city}, {_state}, {_country}");
    }
    public bool IsUSA(){
        if (_country == "USA"){
            return true;
        }
        else {
            return false;
        }
    }

// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string 
// (with newline characters where appropriate)
}