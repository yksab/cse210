using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public bool LiveUSA()
    {
        return _address.LiveUSA();
    }

    public void nameAddress()
    {
        Console.WriteLine("Customer Name: " + _name + ",\n" + _address.FullAddress());
    }
}