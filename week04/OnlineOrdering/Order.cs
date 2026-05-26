

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer      _customer;
 
    public Order(Customer customer)
    {
        _customer = customer;
    }
 
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
 
    public double GetTotalPrice()
    {
        double total = 0;
 
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
 
            //if in USA
        if (_customer.LivesInUSA())
        {
            total += 5; 
        }
            //if not in USA
        else
        {
            total += 35;
        }
 
        return total;
    }
 
    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
 
        foreach (Product product in _products)
        {
            label += $"  {product.GetName()} (ID: {product.GetProductId()}) ${product.GetPricePerUnit():F2}\n";
        }
 
        return label;
    }
 
    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }
}