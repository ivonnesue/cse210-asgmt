using System;

public class Order
{
    private double orderCost = 0;
    private string shippingLabel, packinglabel;

    private double shippingCost = 0;
   
    

    public List<Product> ProductList = new List<Product>();
    //public List <double> ProductPriceList = new List<double>();
    
    Customer customer;

    public void setCustomer(Customer _customer)
    {
        customer = _customer;
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



    public void DisplayPackingLabel()
    {
       foreach(Product product in ProductList)
       {
            packingLabel = product.FormatProduct();
            Console.WriteLine(packingLabel);
       }
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
        foreach (Product product in ProductList)
        {
            orderCost += product.CalculateProductPrice();
        }
        getShippingCost();
        orderCost += shippingCost;
        orderCost = Math.Round(orderCost, 2);
        return orderCost;
    }
    public string getOrderCost()
    {
        return string.Format("${0}", orderCost);
    }

    
}