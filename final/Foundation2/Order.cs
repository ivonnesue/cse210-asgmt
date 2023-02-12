using System;

public class Order
{
    private double OrderCost = 0;
    private string shippingLabel;

    private double shippingCost = 0;
    private string packingLabel;

    public List<Product> ProductList = new List<Product>();
    public List <double> ProductPriceList = new List<double>();
    //private Product product = new Product("", "", "", 0);
    private Address address = new Address();
    Customer customer = new Customer("");
    
    //constructor
    //public Order()
    //{
    //    OrderCost = 0;
    //    shippingCost = 0;
    //}

    public void DisplayProductList()
    {
       foreach(Product product in ProductList)
       {
            Console.WriteLine(product);
       }
    }
    public void getShippingCost()
    {
        bool USshipping = address.IsAddressInUSA();
        if (USshipping == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

    }

    public void setPackingLabel(string _packingLabel)
    {
        packingLabel = _packingLabel;
    }

    public string getPackingLabel()
    {
        return packingLabel;
    }

    public void setShippingLabel(string _shippingLabel)
    {
        shippingLabel = _shippingLabel;
    }
    public void DisplayShippingLabel()
    {
        shippingLabel = String.Format("{0} \n{1}", customer.getCustomerName(), address.FormatAddress());
        Console.WriteLine("Ship To: ");
        Console.WriteLine(shippingLabel);
       
    }

    public double CalculateOrderCost()
    {
        //sums up product prices 
        foreach (double price in ProductPriceList)
        {
            OrderCost += price;
        }
        OrderCost += shippingCost;
        return OrderCost;
    }
    public string DisplayOrderCost()
    {
        return string.Format("${0}", OrderCost);
    }

    
}