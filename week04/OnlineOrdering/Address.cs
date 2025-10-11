using System;
using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool LiveUSA()
    {
        return (_country == "USA") ? true : false;
    }

    public string FullAddress()
    {
        return "Address: " + _streetAddress + ", City: " + _city + ", State/Province: " + _stateProvince + ", Country" + _country;
    }
}