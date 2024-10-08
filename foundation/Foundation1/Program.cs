using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();
        Video video1 = new Video();
        video1._title = "123 456";
        video1._author = "Mr Beast";
        video1._length = 456;

        Video video2 = new Video();
        video2._title = "blues clues";
        video2._author = "Steve";
        video2._length = 4060;

        Video video3 = new Video();
        video3._title = "Pokemon";
        video3._author = "John";
        video3._length = 400;

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        
        foreach(Video vid in videosList){
            vid.DisplayAll();
        }
        
    }
}