public class Product{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public double GetCost()
    {
        return _quantity * _price;
    }

}