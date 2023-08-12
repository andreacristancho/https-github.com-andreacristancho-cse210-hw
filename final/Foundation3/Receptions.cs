using System;

public class Receptions : Event
{

private string _rsvp;

// OJO ACÁ USO UNA CLASE QUE NO ES HEREDADA DE EVENT Y TIENE UN MANEJO DIFERENTE, ES ADDRESS
public Receptions(string title, string description, string date, string time, Address address, string rsvp) : base ( title, description,  date, time, address)
{
    _rsvp=rsvp;
}


public string GetRsvp()
    {
        return _rsvp;
    }

public string GetTypeOfActivity()
{
    return "Receptions";
}
public string GetMoreDetails()
{
    
    return "RSVP: "+ GetRsvp() + "\n" ;
  
    
}

}