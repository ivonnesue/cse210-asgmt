using System;

public class Customer
{
    private string CustomerName;

    private Address address = new Address();

    private bool LivesInUSA;

    public Customer(string _customerName)
    {
        CustomerName = _customerName;
    }

    public void setCustomerAddress(Address _address)
    {
        address = _address;
    }
    public string getCustomerName()
    {
        return CustomerName;
    }

    public bool CXlivesInUSA()
    {
       LivesInUSA = address.IsAddressInUSA();
       return LivesInUSA;
    }

    public string getCustomerAddress()
    {
        return address.FormatAddress();
    }
}