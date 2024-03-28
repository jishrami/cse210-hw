public class Address
{
    public string streetAddress { get; set;}
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }

    public bool isUnitedStates(){
        if (country == "United States" || country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }

    public string GetFullAddress(){
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}