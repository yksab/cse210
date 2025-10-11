using System;


public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void TotalCost()
    {
        Console.WriteLine("\nTOTAL COST");

        float shippingCost;

        shippingCost = (_customer.LiveUSA() == true) ? 5 : 35;

        float productSum = 0;

        foreach (Product product in _products)
        {
            float total = product.TotalProductCost();

            productSum += total;
        }

        float totalCost = shippingCost + productSum;

        Console.WriteLine(string.Format("Total Cost is {0:C}", totalCost));
    }

    public void PackingLabel()
    {
        Console.WriteLine("\nPACKING LABEL");

        foreach(Product product in _products)
        {
            product.NameProductId();
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("\nSHIPPING LABEL");

        _customer.nameAddress();
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
}