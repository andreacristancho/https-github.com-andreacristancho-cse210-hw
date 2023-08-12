using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.Clear();
        Console.WriteLine("    ****   Event Planning Program   ***");
        Console.WriteLine();

        string userChoice = " ";

        while (userChoice != "4")

        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Type of Events");
            Console.WriteLine("1. Lectures");
            Console.WriteLine("2. Receptions");
            Console.WriteLine("3. Outdoor");
            Console.WriteLine("4. Exit");
            Console.Write("Please select a choice from the options: ");
            string response = Console.ReadLine();
            Console.WriteLine();

        

            if (response == "1")
            {

                Console.WriteLine();
                Lectures l1 = new Lectures(
                "Cryptotrading for everyone.", 
                "Basic concepts for beginners in Cryptotrading.", 
                "August 11 2023", 
                "6pm", 
                new Address("5th Street 123", "Los Angeles", "California", "USA"),
                "Oliver Velez",     
                200
                );  

                Console.WriteLine("STANDARD DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine(l1.GetStandardDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("FULL DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ l1.GetTypeOfActivity());
                Console.WriteLine(l1.GetStandardDetails());
                Console.WriteLine(l1.GetMoreDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("SHORT DESCRIPTION_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ l1.GetTypeOfActivity());
                Console.WriteLine("Title: "+ l1.GetTitle());
                Console.WriteLine("Date: " +l1.GetDate());
                Console.WriteLine();

            }

        

            if (response == "2")
            {
                Receptions r1 = new Receptions(
                "Shakira and Lewis Hamilton wedding.", 
                "The wedding of the year after breaking up with the soccer player,Piqué.", 
                "August 12 2023", 
                "8pm", 
                new Address("Avenida del Río ", "Barranquilla", "Atlántico", "Colombia"),
                "RSVP"
                );  

                Console.WriteLine("STANDARD DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine(r1.GetStandardDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("FULL DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ r1.GetTypeOfActivity());
                Console.WriteLine(r1.GetStandardDetails());
                Console.WriteLine(r1.GetMoreDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("SHORT DESCRIPTION_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ r1.GetTypeOfActivity());
                Console.WriteLine("Title: "+ r1.GetTitle());
                Console.WriteLine("Date: " +r1.GetDate());
                Console.WriteLine();

            }

                    if (response == "3")
            {
                Outdoor o1 = new Outdoor(
                "Carlos Vives Show.", 
                "The best songs for his 30 years of artistic life.", 
                "Octubre 21 2023", 
                "8pm", 
                new Address("Estadio Movistar Arena", "Bogota", "Bogotá DC", "Colombia"),
                "Sunny Day"
                );  

                Console.WriteLine("STANDARD DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine(o1.GetStandardDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("FULL DETAILS_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ o1.GetTypeOfActivity());
                Console.WriteLine(o1.GetStandardDetails());
                Console.WriteLine(o1.GetMoreDetails());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue with other marketing messages");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("SHORT DESCRIPTION_Message:");
                Console.WriteLine();
                Console.WriteLine("Type of Event: "+ o1.GetTypeOfActivity());
                Console.WriteLine("Title: "+ o1.GetTitle());
                Console.WriteLine("Date: " +o1.GetDate());
                Console.WriteLine();

            }

                if (response == "4")
                {
                Console.WriteLine("See you later... Bye");
                Console.WriteLine();
                Environment.Exit(0);
                }
            
            
        }
    }
}