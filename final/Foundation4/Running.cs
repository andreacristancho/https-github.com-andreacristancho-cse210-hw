using System;

public class Running : Activity

{
    private double _distance;
    

    public Running (int minutes, string date, double distance) 
        : base(minutes, date)

    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        //Console.Write("How many meters did you run in your exercise day? ");
        //string mtsResponse = Console.ReadLine();
        //double mtsResponseInt = double.Parse(mtsResponse);
        double _kmsDistance = _distance/1000;
        double distRound = Math.Round(_kmsDistance, 2);
    
        return distRound;
    }

    public override double GetSpeed()
    {
        
        double speed = (GetDistance()/GetMinutes())*60;
        //double speedRound = Math.Round(speed, 2);
        return speed;
       
    }

    public override double GetPace()
    {
        double pace = GetMinutes()/GetDistance();
        //double paceRound = Math.Round(pace, 2);
        return pace;
        
    }






}