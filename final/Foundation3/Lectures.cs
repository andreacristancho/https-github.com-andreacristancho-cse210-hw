using System;

public class Lectures: Event

{   
    private string _speaker;
    private int _capacity;

    //public Lectures(string speaker, int capacity)
    //
    // : base(title, description, date, time, address)

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)

    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public string GetTypeOfActivity()
    {
        return "Lectures";
    }
    public string GetMoreDetails()
    {
        return "Speaker: "+ GetSpeaker() + "\n" + "Capacity: "+ GetCapacity()+ " people.";
    
    }
    
    
}