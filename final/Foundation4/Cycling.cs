using System;

public class Cycling : Activity

{
    private int _speed;
    

    public Cycling (int minutes, string date, int speed) 
        : base( minutes, date)

    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed * GetMinutes())/60;
        //double distanceRound = Math.Round(distance, 2);
        return distance;
    }

    public override double GetPace()
    {
        double pace = GetMinutes()/GetDistance();
        //double paceRound = Math.Round(pace, 2);
        return pace;
    }


}