using System;

public class BreathingActivity : Activity

{
    private string _breathMessage;
   
    public BreathingActivity(string name, string description, string duration, string breathMessage)
      : base(name, description, duration)

    {
        _breathMessage = breathMessage;
    } 

    
    public string GetBreathMessage()
    {
        return _breathMessage;
    }

    
}   