using System;

class Prompt
{

    public List<string> _prompts = new List<string>();
    
    public string? _prompt;
    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today? ");
        _prompts.Add("What was the best part of my day?  ");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?  ");
        _prompts.Add("If I had one thing I could do over today what would it be?  ");
    }
    
    //public 
    
    public string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0,4);
        _prompt = _prompts[randomIndex];
        
        return _prompt;
    }

    

    //public void Display()
    //{
    //    foreach (Prompt prompt in _prompts)
    //    {
    //        prompt.Display();
    //    }
    //}
       

}

   
