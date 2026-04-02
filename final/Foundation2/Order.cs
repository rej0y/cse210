class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer._address.GetFullAddress()}";
    }
}