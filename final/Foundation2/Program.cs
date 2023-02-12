using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        Order order1 = new Order();
        Customer customer1 = new Customer("Jane Doe");
        Address address1 = new Address();
        Product product1 = new Product("banana", "abc123", 0.50, 2);
        Product product2 = new Product("milk", "cde456", 3.50, 1);
        order1.ProductList.Add(product1); 
        order1.ProductList.Add(product2);  

        double Product1Price = product1.CalculateProductPrice();
        order1.ProductPriceList.Add(Product1Price);
        double Product2Price = product2.CalculateProductPrice();
        order1.ProductPriceList.Add(Product2Price);

        order1.CalculateOrderCost();
        Console.WriteLine(order1.DisplayOrderCost());
        //order1.DisplayProductList();
        //order1.DisplayShippingLabel();        

    
    }
}