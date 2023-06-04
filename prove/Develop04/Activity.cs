using System;

public class Activity

{
   private string _name;
   private string _description;
   private string _duration;



    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;

    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDuration()
    {
        return _duration;
    }


    public string DisplayStartMessage()
    {
        string text1 = "Welcome to the "+ _name+".";
        string text2 = _description;
        return text1 + "\n" + "\n"+ text2;
    }
    
    public static void GetCounter()
    {
       for (int i = 5; i < 10; i--)
       {
           Console.Write("i");
           Thread.Sleep(1000);
           Console.Write("\b \b"); // Erase the + character
       }
    }
   
   public string DisplayEndMessage()
    {
        Console.WriteLine();
        string text3 ="Well done!!";
        string text4 = "You have completed another"  +" "+ _duration + " seconds of the" + " "+ _name +".";
       
        return text3 + "\n" + text4;
    }
    
}

