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

        Address addressCanada = new Address();
        addressCanada.streetAddress = "456 Maple Avenue";
        addressCanada.city = "Maple Town";
        addressCanada.state = "Ontario";
        addressCanada.country = "Canada";

        Customer john = new Customer();
        john.address = addressCanada;
        john.name = "John Smith";

        // Console.WriteLine(jane.name);
        // Console.WriteLine(jane.isInUnitedStates());

        Product ham = new Product();
        ham.name = "Ham";
        ham.prodID = 1;
        ham.unitPrice = 1.99;
        ham.quantity = 10;

        Product cheese = new Product();
        cheese.name = "Cheese";
        cheese.prodID = 2;
        cheese.unitPrice = 2.49;
        cheese.quantity = 5;

        // Console.WriteLine($"We got {ham.quantity} {ham.name} for ${ham.totalPrice().ToString("C")}");

        Order order1 = new Order();
        order1.AddProduct(ham);
        order1.AddProduct(cheese);
        order1.AddCustomer(jane);

        Order order2 = new Order();
        order2.AddProduct(ham);
        order2.AddProduct(cheese);
        order2.AddCustomer(john);

        order1.packingLabel();
        Console.WriteLine();
        order1.shippingLabel();
        Console.WriteLine();
        order1.totalPrice();
        Console.Read();

        order2.packingLabel();
        Console.WriteLine();
        order2.shippingLabel();
        Console.WriteLine();
        order2.totalPrice();
        Console.Read();
    }
}