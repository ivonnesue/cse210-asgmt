using System;

public class Order
{
    private double OrderCost = 0;
    private string shippingLabel;

    private double shippingCost = 0;
    private string packingLabel;

    public List<Product> ProductList = new List<Product>();
    public List <double> ProductPriceList = new List<double>();
    
    
    Customer customer;

    public void setCustomer(Customer _customer)
    {
        customer = _customer;
    }
    public void DisplayProductList()
    {
       foreach(Product product in ProductList)
       {
            Console.WriteLine(product.FormatProduct());
       }
    }
    public void getShippingCost()
    {
        bool USshipping = customer.CXlivesInUSA();
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
        shippingLabel = String.Format("{0} \n{1}", customer.getCustomerName(), customer.getCustomerAddress());
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
        getShippingCost();
        OrderCost += shippingCost;
        return Math.Round(OrderCost, 2);
    }
    public string getOrderCost()
    {
        return string.Format("${0}", OrderCost);
    }

    
}