using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void GetResponse()
    {
      
      
        _date = DateTime.Now.ToString();
        Prompt newPrompt = new Prompt();
        _prompt = newPrompt.GetPrompt();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt: {_prompt} {_response}");
    }


    
}
