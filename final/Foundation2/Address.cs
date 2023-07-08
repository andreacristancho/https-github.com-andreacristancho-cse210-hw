using System;


class Address

{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    //private List<string> _address;
    private bool _inOrOutUSA;


    public Address (string street, string city, string state, string country)
    
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public string GetStreet()
    {
        return _street;
    }
    

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }


    public string GetAddress()
    {
    
        return _street + " " + _city +" "+_state + " "+ _country;
        

    }

    public bool InorOutUSA()
    {
        if (_country == "USA")

        _inOrOutUSA = true;

        else 
        _inOrOutUSA = false;

        return _inOrOutUSA;
    }

}