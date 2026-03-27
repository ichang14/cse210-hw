public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer; 

    public Order(Customer customer)
    {
        _customer = customer;
    }
}