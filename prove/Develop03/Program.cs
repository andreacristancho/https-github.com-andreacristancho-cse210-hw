using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Creamos un objeto o instancia. Acá estamos instanciando el objeto Rference
        //Damos un estado inicial a  mi Referencia
        // Acá estamos llamando: primero la clase que es Reference
        // luego llamamos al constructor que es "Reference()". Ver Reference.cs línea 11
        Reference ref1 = new Reference();
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        string newRef = ref2.getReference();
        
        //Console.WriteLine(ref1.getReference());
        //Console.WriteLine(ref2.getReference());
    
        //Creo el constructor
        Scripture s = new Scripture(newRef, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
      
        // Para que se ejecuten comandos después de un enter utilizo: 
        

        Console.WriteLine(s.getTextAndRef());
        
        Word word = new Word();
        word.getHiddenWords();
        Console.WriteLine(word.getHiddenWords());

        Console.WriteLine("Press 'Enter' to hide words or type 'quit' to exit:");
        string _response = Console.ReadLine();

        while (_response != "quit")
        {
            word.getHiddenWords();
            s.getTextAndRef();
            Console.WriteLine(s.getTextAndRef());
            Console.WriteLine(word.getHiddenWords());
            Console.WriteLine("Press 'Enter' to hide words or type 'quit' to exit:");
            _response = Console.ReadLine();
        
        }

    }   

}

