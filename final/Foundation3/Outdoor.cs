using System;

public class Outdoor : Event

{
    private string _weather;
    //public Address _address;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base ( title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GetTypeOfActivity()
    {
        return "Outdoor";
    }
    public string GetMoreDetails()
    {
        return "Weather: "+ GetWeather() + "\n" ;
    }

    
}