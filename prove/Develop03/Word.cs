using System;


// public indica que se pueda acceder desde fuera de la clase
public class Word
{
    private string _text;
    private List<string> _hidden;

    public Word()
    {
        _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. ";
        _hidden = new List<string>();
    }

    public string getText()
    {
        string text = _text;
        return text;
    }



    public string getHiddenWords()
    {
        string[] words = _text.Split(' ');

        Random random = new Random();
        int index = random.Next(0, words.Length);

        string palabraoculta = words[index];
        _hidden.Add(palabraoculta);

        words[index] = "_____"; // Placeholder for hidden word

       _text = string.Join(' ', words);
       return  _text;
    }

    
}




