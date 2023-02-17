using System;


public class Address
{
    private string street, city, stateOrProvince, country;

   
    public Address()
    {

    }

    public Address(string _street, string _city, string _stateOrProvince, string _country)
    {
        street = _street;
        city = _city;
        stateOrProvince = _stateOrProvince;
        country = _country;
    }
    public bool IsAddressInUSA()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FormatAddress()
    {
        return String.Format("{0}, \n{1}, {2}, {3}", street, city, stateOrProvince, country);
    }

}