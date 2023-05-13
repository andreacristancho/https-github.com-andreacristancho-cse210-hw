using System;
using System.Collections.Generic;
class Program

{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program.");

        string userNumber = "-1";

        while (userNumber != "5")
        {
            
            Console.WriteLine("Please select one of the following choices:\n 1. Write\n  2. Display\n  3. Load 4\n. Save 5. Quit\n ");
            Console.WriteLine("What would you like to do?");
            userNumber = Console.ReadLine();
    
            
            if (userNumber == "1")
            {
                // VOY ACÁ****
                Entry newEntry = new Entry();
                newEntry.GetResponse();

                //Entry entry = new Entry();
                //entry.GetResponse();
                //journal.entries.Add(entry);
                
                

            }
                
  
            if (userNumber == "2")
            {   // Acá debe mostrar el journal: date, prompt, response


            }
    
    static void GetResponse(Journal journal)
        {
            Entry entry = new Entry();
            entry.GetResponse
        }   

            if (userNumber == "3")
            {
               // Cargar el diario desde un archivo: solicite al usuario un nombre de archivo y 
               // luego cargue el diario (una lista completa de entradas) desde ese archivo. 
               // Esto debería reemplazar cualquier entrada almacenada actualmente en el diario.

            }

            if (userNumber == "4")
            {
                //  Guardar el diario en un archivo: solicite al usuario un nombre de archivo 
                //  y luego guarde el diario actual (la lista completa de entradas) 
                //  en esa ubicación de archivo.
        
            }
        }
    }     


    


          


}

