class Product
{
    private string _name;
    private string _productId;
    private int _pricePerUnit;
    private int _quantity;
    public Product(string name, string productId, int pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity; 
    }
    public int PriceOfProductBeforeShipping()
    {
        return _quantity * _pricePerUnit;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}