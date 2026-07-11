using System.Security.Cryptography.X509Certificates;

class Customer
{
    private string _name;
    private Address _address;
    public Customer()
    {
        
    }
    public Customer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(streetAddress, city, stateOrProvince, country);
    }
    public bool doTheyLiveInTheUS()
    {
        if(_address.isInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Address GetAddress()
    {
        return _address;
    }
    public string GetName()
    {
        return _name;
    }
}