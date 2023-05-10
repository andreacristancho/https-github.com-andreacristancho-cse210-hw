using System;

public class Prompt
{
    public List<Prompt>_prompts = new List<Prompt>();


    public void GetPrompt()
    {
        string filename = "myfile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");   
            
            Random random = new Random();
            int randomIndex = random.Next(parts.Count);
            string randomMessage = lines[randomIndex];
            
        }
        Console.WriteLine($"{randomMessage}");
    }

    public void Display()
    {
        foreach (Prompt prompt in _prompts)
        {
            prompt.Display();
        }
    }
       

}

   


