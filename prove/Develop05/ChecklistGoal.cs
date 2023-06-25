using System;

public class ChecklistGoal : Goal
{

    private int _totalTimes;
    private int _times;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool fulfilled, int totalTimes, int times, int bonus)
        : base(name, description, points, fulfilled)

        {
            _totalTimes = totalTimes;
            _times = times;
            _bonus = bonus;
        }

   
    public int GetTotalTimes()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _totalTimes = Console.ReadLine();
        int _totalTimesInt = int.Parse(_totalTimes);
        return _totalTimesInt;
    }

    public int SetTimes()
    {
        return 0;
    }
    public int GetTimes()
    {
        return _times;
    }
     public int GetBonus()
    {
        Console.Write("What is the bonus for accomplishing it thet many times? ");
        string _bonus = Console.ReadLine();
        int _bonusInt = int.Parse(_bonus);
        return _bonusInt;
    }

   

    public override void CreateGoal()
    {
       base.CreateGoal();
       _totalTimes = GetTotalTimes();
       _times = SetTimes();
       _bonus = GetBonus();
    }   


    public override string DisplayGoalsList()
    {

        return base.DisplayGoalsList() +" -- Currently completed: "+ _times+"/"+_totalTimes;
    }


    public override string DisplayInFile()
    {
        return "ChecklistGoal: "+base.DisplayInFile() +", "+ _bonus+"/"+_totalTimes+", "+_times;

    }
}   