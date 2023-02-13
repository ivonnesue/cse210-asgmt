using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        //Order 1
        Console.WriteLine("Order1");
        Order order1 = new Order();
        
        Customer customer1 = new Customer("Jane Doe");
        order1.setCustomer(customer1);
       
        Address address1 = new Address("123 A Street", "A City", "AState", "USA");
        customer1.setCustomerAddress(address1);
        Product product1 = new Product("bag", "abc123", 25.00, 1);
        Product product2 = new Product("shoes", "cde456", 35.00, 1);
        Product product3 = new Product("blouse", "fgh789", 15.98, 2);
        order1.ProductList.Add(product1); 
        order1.ProductList.Add(product2); 
        order1.ProductList.Add(product3);

        double Product1Price = product1.CalculateProductPrice();
        order1.ProductPriceList.Add(Product1Price);
        double Product2Price = product2.CalculateProductPrice();
        order1.ProductPriceList.Add(Product2Price);
        double product3Price = product3.CalculateProductPrice();
        order1.ProductPriceList.Add(product3Price);

        order1.DisplayProductList();
        Console.WriteLine();

        order1.CalculateOrderCost();
        Console.WriteLine(order1.getOrderCost());
        Console.WriteLine();

        order1.DisplayShippingLabel();      
        Console.WriteLine("--------------------------------");
        Console.WriteLine();
        
        
        //Order2
        Console.WriteLine("Order #2");
    
        Order order2 = new Order();
        Customer customer2 = new Customer("Joe Parker");
        order2.setCustomer(customer2);
        
        Address address2 = new Address("123 B Street", "B City", "BProvince", "Canada");
        customer2.setCustomerAddress(address2);
        
        Product product2a = new Product("headphones", "ijk123", 50.00, 1);
        Product product2b = new Product("shirt", "lmn456", 35.00, 1);
        Product product2c = new Product("pants", "opq789", 15.98, 2);
        order2.ProductList.Add(product2a); 
        order2.ProductList.Add(product2b); 
        order2.ProductList.Add(product2c);

        double Product2aPrice = product2a.CalculateProductPrice();
        order2.ProductPriceList.Add(Product1Price);
        double Product2bPrice = product2b.CalculateProductPrice();
        order2.ProductPriceList.Add(Product2Price);
        double product2cPrice = product2c.CalculateProductPrice();
        order2.ProductPriceList.Add(product3Price);

        order2.DisplayProductList();
        Console.WriteLine();

        order2.CalculateOrderCost();
        Console.WriteLine(order2.getOrderCost());
        Console.WriteLine();

        order2.DisplayShippingLabel();       



    }
}