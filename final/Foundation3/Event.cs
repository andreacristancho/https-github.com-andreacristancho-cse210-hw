using System;

public class Event

{

    private string _title;
    private string _description;
    private string _date;
    private string _time;
    public Address _address; 
    // así llamo una clase que no es heredada de Event.
    public Event(string title, string description, string date, string time, Address address)

    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        
    }

    public string GetTitle()
    {
        return _title;

    }

    public string GetDescription()
    {
        return _description;
        
    }

    public string GetDate()
    {
        return _date;
        
    }

    public string GetTime()
    {
        return _time;
        
    }


    public string GetStandardDetails()
    {
        return "Title: " + GetTitle()+"\n"+
        "Description: "+GetDescription()+ "\n" +
        "Date: "+GetDate()+"\n"+
        "Time: "+GetTime()+"\n" + 
        "Address: "+ _address.GetAddress();  
    }

    


}