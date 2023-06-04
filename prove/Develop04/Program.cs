using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();

        if (response == "1")
        {   
            //Mensaje inicial
            BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "", "");
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine(a1.DisplayStartMessage());
            Console.WriteLine();
            Console.WriteLine("How long, in seconds, you like for your session?");
            string userResponse = Console.ReadLine();
            int seconds_breath = int.Parse(userResponse);
            Console.Clear();

            //Spinner del Get ready
            Console.Write("Get ready...");
            GetReadySpinner();
            Console.WriteLine();
            //Mensajes de Respiración

            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_breath);

            while (DateTime.Now < endTime)
            {
                BreathingActivity a2 = new BreathingActivity("","", "", "Breath in...");
                Console.WriteLine(a2.GetBreathMessage());
                GetCounter();
                Console.WriteLine();
                BreathingActivity a3 = new BreathingActivity("","", "", "Breath out...");
                Console.WriteLine(a3.GetBreathMessage());
                GetCounter();
                Console.WriteLine();
            }


            BreathingActivity a4 = new BreathingActivity("Breathing Activity","",userResponse,"");
            Console.WriteLine(a4.DisplayEndMessage());
            Console.WriteLine();
            

        }   
        else if (response == "2")
        {
            List<string> prompts = new List<string>(); // Crear una instancia de la lista
            List<string> questions = new List<string>();
            ReflectingActivity r1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "", prompts, questions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine(r1.DisplayStartMessage());
            Console.WriteLine();
            Console.WriteLine("How long, in seconds, woul you like for your session?");
            string userResponse1 = Console.ReadLine();
            int seconds_reflect = int.Parse(userResponse1);
            Console.Clear();

            Console.Write("Get ready...");
            GetReadySpinner();
            Console.WriteLine();
           
            
            //ReflectingActivity r3 = new ReflectingActivity("", "", "", randomPrompt);
            //string randomPrompt = r3.GetRandomPrompt();
            //Console.WriteLine(randomPrompt);
            
            ReflectingActivity r3 = new ReflectingActivity("Reflecting Activity", "", "", prompts, questions);
            Console.WriteLine(r3.GetRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in: ");
            GetCounter();
            Console.Clear();
            ReflectingActivity r4 = new ReflectingActivity("Reflecting Activity", "", "", prompts, questions);
            
            // ACÁ DEBERÍA HABER UN WHILE MIENTRAS EL TIEMPO ESTÉ PÒR DEBAJO DE USER_RESPONSE
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_reflect);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(r4.GetRandomQuestion());
                GetReadySpinner();
            }

 
            ReflectingActivity list1 = new ReflectingActivity("Reflecting Activity","",userResponse1, prompts, questions);
            Console.WriteLine(list1.DisplayEndMessage());
            Console.WriteLine();
        }

        else if (response == "3")
        {
            List<string> listingMessages = new List<string>();
            List<string> userItems = new List<string>();

            Console.Clear();
            ListingActivity a1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", "", listingMessages, userItems);
            Console.WriteLine();
            Console.WriteLine(a1.DisplayStartMessage());
            Console.WriteLine();
            Console.WriteLine("How long, in seconds, woul you like for your session?");
            string userResponse2 = Console.ReadLine();
            int seconds_list = int.Parse(userResponse2);
            Console.Clear();


            Console.Write("Get ready...");
            GetReadySpinner();
            Console.WriteLine();

            ListingActivity list2 = new ListingActivity("", "", "", listingMessages,userItems);
            Console.WriteLine(list2.GetRandomPrompt());
            Console.WriteLine("You may begin in: ");
            GetCounter();
            Console.Clear();



            ListingActivity list3 = new ListingActivity("Listing Activity", "", userResponse2, listingMessages, userItems);
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_list);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(list3.GetUserItems());
            }
            int count = userItems.Count;
            Console.WriteLine();
            Console.WriteLine("You listed " + count+ " items");
            
            


            ListingActivity list4 = new ListingActivity("Listing Activity", "", userResponse2, listingMessages, userItems);
            Console.WriteLine(list4.DisplayEndMessage());
        }
        else if (response == "4")
        {
            Console.WriteLine("Bye, thank yourself for spending this time.");
            return;
        }
        else
        {
            Console.WriteLine("Please select a valid option.");
        }
    }
    public static void GetReadySpinner()
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
    }

    public static void GetCounter()
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

}