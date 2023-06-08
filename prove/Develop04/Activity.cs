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
    
    public int GetHowLong()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, you like for your session?");
        string userResponse = Console.ReadLine();
        int seconds_breath = int.Parse(userResponse);
        Console.Clear();
        return seconds_breath;
    }
   
   

    public string DisplayEndMessage()
    {
        Console.WriteLine();
        string text3 = "Well done!!";
        Console.WriteLine(text3);
        GetReadySpinner();
        string text4 = "You have completed another" + " " + _duration + " seconds of the" + " " + _name + ".";
        Console.WriteLine(text4);
        GetReadySpinner();
        return text3 + "\n" + text4;
    }



    public void GetCounter()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            for (int j = 5; j >0 ; j--)
            {
                Console.Write(j +"");
                Thread.Sleep(1000);
                Console.Write("\b \b"); 
            }
        }
    }


    public void GetReadySpinner()
    {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("\\");
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b"); 
        } 
        Console.WriteLine();
    }

}