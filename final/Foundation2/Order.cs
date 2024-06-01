public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(string name, string streetAddress, string city, string state, string country)
    {
        _customer = new Customer(name, streetAddress, city, state, country);
    }
    public void AddProduct(string name, string productID, double price, int quantity)
    {
        _products.Add(new Product(name, productID, price, quantity));
    }
    public double CalculateCost()
    {
        //customer is assumed american, so shipping cost is $5
        double sum = 5;
        //adding $30 to make the shipping cost $35 if the customer is not american
        if (!_customer.IsUSA())
        {
            sum += 30;
        }
        foreach (Product product in _products)
        {
            sum += product.GetCost();
        }
        

        return sum;
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"\n{product.GetName()}: {product.GetProductID()}";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
        
    }
}