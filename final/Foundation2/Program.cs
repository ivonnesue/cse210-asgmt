using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        //Order 1
       
        List<Order> orderList = new List<Order>
        {
            new Order(),
            new Order(),
        };
        //Order order1 = new Order();
        
        Customer customer1 = new Customer("Jane Doe");
        orderList[0].setCustomer(customer1);
       
        Address address1 = new Address("123 A Street", "A City", "AState", "USA");
        customer1.setCustomerAddress(address1);

        List<Product> newProductList = new List<Product>
        {
            new Product("bag", "abc123", 25.00, 1),
            new Product("shoes", "cde456", 35.00, 1),
            new Product("blouse", "fgh789", 15.98, 2),

        };
        orderList[0].ProductList.AddRange(newProductList);


        //Order2
        
        Customer customer2 = new Customer("Joe Parker");
        orderList[1].setCustomer(customer2);
        
        Address address2 = new Address("123 B Street", "B City", "BProvince", "Canada");
        customer2.setCustomerAddress(address2);

        newProductList = new List<Product>
        {
            new Product("headphones", "ijk123", 50.00, 1),
            new Product("shirt", "lmn456", 35.00, 1),
            new Product("pants", "opq789", 15.98, 2),
        };
        orderList[1].ProductList.AddRange(newProductList);
       
        
        foreach (Order order in orderList)
        {
           
           int orderNumber = orderList.IndexOf(order);
           orderNumber ++;
           Console.WriteLine($"Order # {orderNumber}");
        
            order.DisplayPackingLabel();
            order.CalculateOrderCost();
            Console.WriteLine();

            Console.WriteLine($"Total Order cost: {order.getOrderCost()}");
            Console.WriteLine();
            order.DisplayShippingLabel();  
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }

    }
}