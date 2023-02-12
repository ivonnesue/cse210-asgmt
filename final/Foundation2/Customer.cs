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
    public string getCustomerName()
    {
        return CustomerName;
    }

    public void CXlivesInUSA()
    {
       LivesInUSA = address.IsAddressInUSA();
    }

}