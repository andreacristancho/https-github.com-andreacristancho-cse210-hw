using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Response()
    {
        //Pide la respuesta al prompt
        
        
        //Console.Write("")
    }


    public void Date()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine("{dateText}");
        Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt: {_prompt} {_response}");
    }



    
}