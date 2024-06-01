public class Customer{
    private string _name;
    private Address _address;
    public Customer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address = new Address(streetAddress, city, state, country);
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}