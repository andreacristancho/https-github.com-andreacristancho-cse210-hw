using System;

public class ListingActivity : Activity

{
    private List<string>_listingMessage = new List<string>();
    private List<string> _userItems;

    public ListingActivity(string name, string description, string duration, List<string> listingMessage, List<string> userItems)
      : base(name, description, duration)

    {
        _listingMessage = listingMessage;
        _userItems = userItems;
    }

    public string GetRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();
        List<string>_prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

      Random random = new Random();
      int index = random.Next(_prompts.Count); 
      string _prompt = _prompts[index];
      
      return "--- "+_prompt+" ---";
    }

    // DEBO REVISAR PORQUE IMPRIME MAL Y NO ME SUMA LOS ITEMS DE LA LISTA
    public string GetUserItems()
    {
        List<string>_userItems = new List<string>(); 

        Console.WriteLine(">");
        string item = Console.ReadLine();
        _userItems.Add(item);
        int count = _userItems.Count;
        return item;

    }

   

}
