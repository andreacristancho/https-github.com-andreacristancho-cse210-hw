using System;

using System.Collections.Generic;

class Comment 
{

    private string _viewerName;
    private string _text;


    public Comment(string viewerName, string text)
    {
        _viewerName=viewerName;
        _text = text;
    }
    public void DisplayViewerNameText()
    {
        Console.WriteLine($"{_text}. By: {_viewerName}.");
    }

    
}
