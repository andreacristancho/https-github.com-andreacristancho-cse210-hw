using System;


public abstract class Shape

{

    private string _color;


    public Shape(string color)
    {
        _color = color;
    }


    public string SetColor()
    {
        return _color;
    }

    public string GetColor()
    {
        return _color;
    }
    //  Yo podría utilizar el siguiente código:
    //  public virtual double GetArea()
    //  {
    //      return 0;
    //  }

    //  pero podemos reemplazar por ...
    // y ojo!!!! también la clase se debe declarar como abstract arriba.
    public abstract double GetArea();


}