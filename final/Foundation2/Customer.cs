public class Customer
{
    public string name { get; set; }
    public Address address { get; set; }

    public bool isInUnitedStates(){
        if (address.isUnitedStates()){
            return true;
        }
        else{
            return false;
        }
    }
}