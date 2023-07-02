using System;
using System.Collections.Generic;


class Video
{
    string _title;
    string _author;
    int _duration;
    List<Comment> _commentsList;
    public Video(string title, string author, int duration)

    {
    _title = title;
    _author = author;
    _duration = duration;
    _commentsList = new List<Comment>();
    }
  
    //List<string> Comment   = new List<string>();

    
    public void GetCommentsToList(string viewerName, string text)
    {
        Comment comment = new Comment(viewerName,text);
        _commentsList.Add(comment);

    }

    public void DisplayDataVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Video: {_title}. Author: {_author}. Duration {_duration}");   
                                       
    }
    
    public int GetTotalComments()
    {
        return _commentsList.Count();
    }

    public List<Comment> Get_commentsList()
    {
        return _commentsList;
    }

    public void DisplayComments()
    {
        int commentNumber = 1;
        foreach (Comment comment in _commentsList)
        {
            
            Console.Write($"{commentNumber}.");
            comment.DisplayViewerNameText();
            commentNumber++;
        }
    }




}
                

