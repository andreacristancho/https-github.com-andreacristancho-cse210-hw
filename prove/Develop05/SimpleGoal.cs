using System;


public class SimpleGoal : Goal

{
    public SimpleGoal(string name, string description, int points, bool fulfilled)
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
        return "SimpleGoal: "+base.DisplayInFile();

    }
    
}