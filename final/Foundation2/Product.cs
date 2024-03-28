public class Product
{
    public string name { get; set; }
    public int prodID { get; set; }
    public double unitPrice { get; set; }
    public int quantity { get; set; }

    public double totalPrice()
    {
        double total = unitPrice * quantity;
        return total;
    }
}