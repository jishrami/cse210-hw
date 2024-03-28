public class Order
{
    public List<Product> products = new List<Product>();
    public List<Customer> customers = new List<Customer>();

    public double orderTotal()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.totalPrice();
        }
        return total;
    }

    public void packingLabel()
    {
        foreach (Product item in products)
        {
            string label = $"{item.prodID} {item.name}";
            Console.WriteLine(label);
        }
    }

    public void shippingLabel()
    {
        foreach (Customer customer in customers)
        {
            string shipping = $"{customer.name}\n{customer.address.streetAddress}\n{customer.address.city}, {customer.address.state}\n{customer.address.country}";
            Console.WriteLine(shipping);
        }
    }

    public void totalPrice()
    {
        Console.WriteLine(orderTotal() + ShippingCost());
    }

    public int ShippingCost()
    {
        foreach (Customer customer in customers)
        {
            if (customer.isInUnitedStates())
            {
                return 5;
            }
            else
            {
                return 35;
            }

        }
        return 35;
    }

    public void CreateOrder(Product product, Customer customer)
    {
        products.Add(product);
        customers.Add(customer);
    }

}