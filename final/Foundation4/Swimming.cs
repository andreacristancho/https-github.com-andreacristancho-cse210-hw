using System;

public class Swimming : Activity

{
    private int _laps;
    

    public Swimming (int minutes, string date, int laps) 
        : base(minutes, date)

    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        double distance = _laps*50/1000;
        //double distanceRound = Math.Round(distance, 2);
        return distance;
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
        double paceRound = Math.Round(pace, 2);
        return paceRound;
    }

}