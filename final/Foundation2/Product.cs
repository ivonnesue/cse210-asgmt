using System;

public class Product
{
    private string ProductName;

    private string ProductID;

    private int quantity;

    private double productPrice = 0;

    private double ProductoTotalPrice;

    public Product(string _ProductName, string _ProductID, double _productPrice, int _quantity)
    {
        ProductName = _ProductName;
        ProductID = _ProductID;
        productPrice = _productPrice;
        quantity = _quantity;

    }
    
    
    public string FormatProduct()
    {
        return String.Format("Product: {0}, {1}, {2}", ProductName, ProductID, productPrice);
    }
    public double CalculateProductPrice()

    {
        ProductoTotalPrice = productPrice * quantity;
        return ProductoTotalPrice;
    }

}