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
            int seconds_breath= a1.GetHowLong();
            string userResponse = seconds_breath.ToString();
           
            //Get Ready
            Console.Write("Get ready...");
            a1.GetReadySpinner();
          

            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_breath);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine();
                BreathingActivity a2 = new BreathingActivity("Breathing Activity","", "", "Breath in...");
                Console.Write(a2.GetBreathMessage());
                a2.GetCounter();
                
                Console.WriteLine();
                BreathingActivity a3 = new BreathingActivity("Breathing Activity","", "", "Breath out...");
                Console.Write(a3.GetBreathMessage());
                a2.GetCounter();
                
            }

            //Mensaje final
            BreathingActivity a4 = new BreathingActivity("Breathing Activity","",userResponse,"");
            a4.DisplayEndMessage();
            Console.WriteLine();
            

        }   
        else if (response == "2")
        {
            List<string> prompts = new List<string>(); // Crear una instancia de la lista prompts
            List<string> questions = new List<string>(); // Crear una instancia de la lista questions
            ReflectingActivity r1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "", prompts, questions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine(r1.DisplayStartMessage());
            int seconds_reflect = r1.GetHowLong();
            string secondsReflectString = seconds_reflect.ToString();
     

            Console.Write("Get ready...");
            r1.GetReadySpinner();
          
           
            ReflectingActivity r3 = new ReflectingActivity("Reflecting Activity", "", secondsReflectString, prompts, questions);
            Console.WriteLine(r1.GetRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in: ");
            r1.GetCounter();
            Console.Clear();


            //ReflectingActivity r4 = new ReflectingActivity("Reflecting Activity", "", "", prompts, questions);
            
            // WHILE MIENTRAS EL TIEMPO ESTÉ PÒR DEBAJO DE USER_RESPONSE
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_reflect);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(r1.GetRandomQuestion());
                r1.GetReadySpinner();
            }

 
            //ReflectingActivity list1 = new ReflectingActivity("Reflecting Activity","",userResponse1, prompts, questions);
            r3.DisplayEndMessage();
            Console.WriteLine();
        }

        else if (response == "3")
        {
            List<string> listingMessages = new List<string>();
            List<string> userItems = new List<string>();

            Console.Clear();
            ListingActivity list1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", "", listingMessages, userItems);
            Console.WriteLine();
            Console.WriteLine(list1.DisplayStartMessage());
            int seconds_list = list1.GetHowLong();
            string seconds_list_string = seconds_list.ToString();
          


            Console.Write("Get ready...");
            list1.GetReadySpinner();
            

            ListingActivity list2 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", seconds_list_string, listingMessages,userItems);
            Console.WriteLine(list2.GetRandomPrompt());
            Console.WriteLine("You may begin in: ");
            list2.GetCounter();
            Console.Clear();



            //ListingActivity list3 = new ListingActivity("Listing Activity", "", seconds_list_string, listingMessages, userItems);
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds_list);

            List<string> countListString = new List<string>();

            while (DateTime.Now < endTime)
            {
                countListString = list2.GetUserItems();
                
            }

            Console.WriteLine(countListString);
            
            list2.GetUserItemsSum(countListString);



            // NO HE PODIDO CUADRAR LA SUMA DE LOS ITEMS DE LA LISTA DE GetUserItems

            //string countList = list2.GetUserItemsSum();
           // Console.WriteLine("prueba de Andrea"+ countList);
            
            
            
            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            //List<string> nombres = new List<string> { "Juan", "María", "Pedro", "Luisa" };

            //for (int i = 0; i < userItems.Count; i++)
            //{
            //    string item = userItems[i];
            //    int count = int.Parse(item);
            //    // Realiza alguna operación con 'nombreActual'
            //    Console.WriteLine(count);
            //}
            //string conteoList = (list1.GetUserItems());
            //int conteoTotal = int.Parse(conteoList);
            //Console.WriteLine();
            
            
            //Console.WriteLine("You listed " + total + " items");
            
            


            //ListingActivity list4 = new ListingActivity("Listing Activity", "", userResponse2, listingMessages, userItems);
            list2.DisplayEndMessage();
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
    


}
