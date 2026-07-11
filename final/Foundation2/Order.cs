using System.Net.Http.Headers;

class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _currentCustomer = new Customer();
    private int _costOfOrder;
    private int _shippingCost;
    private string _packingLabel;
    private string _shippingLabel;

    public void addCustomer(Customer addedCustomer)
    {
        _currentCustomer = addedCustomer;
    }
    public void addProduct(Product addedProduct)
    {
        _productList.Add(addedProduct);
    }
    public void TotalCostOfOrder()
    {
        foreach(Product currentProduct in _productList)
        {
            _costOfOrder += currentProduct.PriceOfProductBeforeShipping();
        }
        _costOfOrder += _shippingCost;
    }
    public void CreatePackingLabel()
    {
        foreach(Product myProduct in _productList)
        {
            _packingLabel += $"{myProduct.GetName()}, {myProduct.GetProductId()}, ";
        }
    }
    public void CreateShippingLabel()
    {
        foreach(Product myProduct in _productList)
        {
            _shippingLabel += $"Name: {myProduct.GetName()}, Product ID: {myProduct.GetProductId()}; ";
    }   }
    public void CalculateShippingCost()
    {
        if(_currentCustomer.doTheyLiveInTheUS())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }
    public void GetPackingLabel()
    {
        Console.WriteLine($"Packing Label: {_packingLabel}");
    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"Shipping Label: {_shippingLabel}");
    }
    public void GetTotalCost()
    {
        Console.WriteLine($"Cost: {_costOfOrder}");
    }
}