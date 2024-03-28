using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address = new Address();
        address.streetAddress = "123 Main Street";
        address.city = "Anytown";
        address.state = "Alberta";
        address.country = "USA";

        Customer jane = new Customer();
        jane.address = address;
        jane.name = "Jane Doe";

        // Console.WriteLine(jane.name);
        // Console.WriteLine(jane.isInUnitedStates());

        Product ham = new Product();
        ham.name = "Ham";
        ham.prodID = 1;
        ham.unitPrice = 1.99;
        ham.quantity = 10;

        // Console.WriteLine($"We got {ham.quantity} {ham.name} for ${ham.totalPrice().ToString("C")}");

        Order order = new Order();
        order.CreateOrder(ham, jane);

        order.packingLabel();
        order.shippingLabel();
        order.totalPrice();
    }
}