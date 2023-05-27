using System;

public class Scripture
{
    private string _reference;
    private string _text;



    public Scripture(string _reference, string _text)
    {
        this._reference = _reference;
        this._text = _text;
    }

    public string getTextAndRef()
    {
        return _reference + " " + _text;
    }
}

