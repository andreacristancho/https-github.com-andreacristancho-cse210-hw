using System;
public class Reference
{

   private string _name;
   private int _chapter;
   private int _startverse;
   private int _endverse;
    
    // Constructor 1
    public Reference()
    {
        _name = "John";
        _chapter = 3;
        _startverse = 16;
        _endverse = 16;
    }

    // Constructor 2
    public Reference(string _bookname, int _newchapter, int _newstartverse, int _newendverse)
    {
        _name = _bookname;
        _chapter = _newchapter;
        _startverse = _newstartverse;
        _endverse = _newendverse;
    
    }
    //Si tiene return debe indicar que es string, int, double, etc.
    
    // Método Getter
    public string getReference()
    {
        if (_startverse != _endverse)
        {
            return _name +" "+ _chapter+": "+ _startverse +"-"+ _endverse;
        }
        else 
        return _name +" "+ _chapter+": "+ _startverse;
        
    }

}
   


