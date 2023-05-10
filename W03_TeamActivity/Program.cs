using System;
using Syste.Collections.Generic;


class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();

        int userNumber = -1;
        while (userNumber != 5)
        {
            
            int userNumber = PromptChoice();
            
            
            if (userNumber = 1)
            {
                // Acá debe salir un prompt Get prompt
                Prompt newprompt = new Prompt();
                newprompt.GetPrompt();
                // Debe recoger la respuesta
                string response = Console.ReadLine();
                // Debe mostrar la fecha, el prompt y la response

                


            }
  
            if (userNumber = 2)
            {   // Acá debe mostrar el journal: date, prompt, response


            }
            

            if (userNumber = 3)
            {
               // Cargar el diario desde un archivo: solicite al usuario un nombre de archivo y 
               // luego cargue el diario (una lista completa de entradas) desde ese archivo. 
               // Esto debería reemplazar cualquier entrada almacenada actualmente en el diario.

            }

            if (userNumber = 4)
            {
                //  Guardar el diario en un archivo: solicite al usuario un nombre de archivo 
                //  y luego guarde el diario actual (la lista completa de entradas) 
                //  en esa ubicación de archivo.
        
            }
        }
    }     


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the journal program.");
    }


    static int PromptChoice()
    {
         Console.Write("Please select one of the following choices:1. Write  2. Display  3. Load 4. Save 5. Quit ");
         Console.Write("What would you like to do?");
         string num = Console.ReadLine();
         int number = int.Parse(num);
         return number;
    }
          
        
     
        
        
        
       





}

