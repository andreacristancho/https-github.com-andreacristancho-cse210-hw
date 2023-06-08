using System;

public class Rectangle : Shape

{
    private double _side;
    private double _hight;

    public Rectangle (string color, double side, double hight)
      : base(color)
    {
        _side = side;
        _hight = hight;
    }

    public override double GetArea()
    {
        return _side*_hight;

    }

}