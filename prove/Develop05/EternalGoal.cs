using System;


public class EternalGoal : Goal

{
    public EternalGoal(string name, string description, int points, bool fulfilled)
     : base(name, description, points, fulfilled)
    {

    }
    public override void CreateGoal()
    
    {
       base.CreateGoal();
    }
    

     public override string DisplayGoalsList()
    {

        return base.DisplayGoalsList();

    }

    public override string DisplayInFile()
    {
        return "EternalGoal: "+base.DisplayInFile();

    }

}