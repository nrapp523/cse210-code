class Address
{
    private string _streetAddress;
    private string _entireAddress;
    private string _country;
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _country = country;
        _entireAddress = $"{streetAddress},\n {city},\n {stateOrProvince},\n {country}";
    }
    public string GetAddressString()
    {
        return _entireAddress;
    }
    public bool isInUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
}