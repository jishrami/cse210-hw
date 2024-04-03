public class Address
{
    public string _street { set; get; }
    public string _city { set; get; }
    public string _state { set; get; }
    public string _country { set; get; }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}