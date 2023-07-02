using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video de Andrea", "Andrea", 60);
        video1.GetCommentsToList("Pepe", "Muy bueno");
        video1.GetCommentsToList("Ana", "feo, aburrido");
        video1.GetCommentsToList("Sergio", "Excelente contenido");

        Video video2 = new Video("Video de Juan", "Juan", 45);
        video2.GetCommentsToList("Hugo", "Fatal");
        video2.GetCommentsToList("Paco", "Aburrido todo el video");
        video2.GetCommentsToList("Luis", "No me gustó");

        Video video3 = new Video("Video de Maria Paula", "Maria Paula Díaz", 45);
        video3.GetCommentsToList("Gustavo", "Hermoso");
        video3.GetCommentsToList("Juan Pablo", "Edificante");
        video3.GetCommentsToList("César", "Interesante");

        List<Video> videos = new List<Video> {video1, video2, video3};
        

        foreach (Video video in videos)
        {
            video.DisplayDataVideo();
            video.DisplayComments();
            
        }

    }
    
}