using System;

public class Activity

{
    private int _minutes;
    private string _date;

    public Activity (int minutes, string date)

    {
        _minutes = minutes;
        _date = date;
    }

    public int GetMinutes()
    {
        //Console.Write ("How long (minutes) did you exercise?  ");
        //string _minutes = Console.ReadLine();
        //int _minutesInt = int.Parse(_minutes);
        return _minutes;
    }

    public string GetDate()
    {
        //DateTime currentDate = DateTime.Now;
        //string dateString = currentDate.ToString("dd MM yyyy");
        return _date;
          
    }

    public virtual double GetDistance()
    {
        return -1.0;
    }

    public virtual double GetSpeed()
    {
        return -1.0;
    }

    public virtual double GetPace()
    {
        return -1.0;
    }

    public string GetSummary()
    {
        return "Distance: "+ Math.Round(GetDistance(),2) + "kms \nSpeed: " + Math.Round(GetSpeed(),2) + " km per hr" + "\nPace: " + Math.Round(GetPace(),2) + " min per km";
    }
    
}