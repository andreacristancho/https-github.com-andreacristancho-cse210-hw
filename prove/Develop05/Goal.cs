using System;
using System.Collections.Generic;


public class Goal

{
    private string _name;
    private string _description;
    private int _points;
    private bool _fulfilled;

    
    public Goal(string name, string description, int points, bool fulfilled)
    {
        _name = name;
        _description = description;
        _points = points;
        _fulfilled = fulfilled;

    }

    public string GetName()
    {
       Console.Write("What is the name of your goal? ");
       string _name = Console.ReadLine();
       return _name;
    }

    public string GetDescription()
    {
        Console.Write("Write a description of the goal: ");
        string _description = Console.ReadLine();
        return _description;
    }
    public int GetPoints()
    {
       Console.Write("How many points has this goal: ");
       string _points = Console.ReadLine();
       int _pointsInt = int.Parse(_points);
       return _pointsInt;
    }

    public bool GetFulilled()
    {
        return _fulfilled;
    }
    

    public virtual void CreateGoal()
    {
       _name = GetName();
       _description = GetDescription();
       _points = GetPoints();
       
    
    }

    

    public string MenuOptions()
    {   Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

        return userChoice;


    }

    public string TypeOfGoal()
    {   Console.WriteLine();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Wich type of goal would you like to create? ");
        string typeUserChoice = Console.ReadLine();

        return typeUserChoice;


    }
    // OJO!!! VIRTUAL DEFINE UN CONTENIDO Y ABSTRACT NO. ABSTRACT TAMBIÉN SE DEBE DEFINIR LA CLASE
    // ABSTRACT NO LLEVA CORCHETES PQ NO DEFINE NADA Y SÍ LLEVA ;
    public virtual string DisplayGoalsList()
    {
        
        return "[ ] "+_name +" ("+_description+") "+_points;

    }

    public virtual string DisplayInFile()
    {
        
        return _name +", "+_description+", "+_points+", "+_fulfilled;

    }

    
}