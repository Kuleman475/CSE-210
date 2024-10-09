using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Giving away a house to a homeless person";
        video1._author = "Mr Beast";
        video1._length = 1556;
        Comment comment1 = new Comment();
        comment1._commentor = "Josh";
        comment1._commentText = "I love Mr Beast";
        video1._comments.Add(comment1);
           
        Comment comment2 = new Comment();
        comment2._commentor = "Sarah";
        comment2._commentText = "Mr Beast is soooooo genrous!! :)";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._commentor = "Morgan";
        comment3._commentText = "$$$$$$$";
        video1._comments.Add(comment3);


        Video video2 = new Video();
        video2._title = "Blues Clues";
        video2._author = "Steve";
        video2._length = 1060;

        Comment comment4 = new Comment();
        comment4._commentor = "Bartholomew";
        comment4._commentText = "I love Bluey!";
        video2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._commentor = "Karen";
        comment5._commentText = "The Clues are right in front of your face 2 stars.";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._commentor = "Kent";
        comment6._commentText = "I miss the old blues clues";
        video2._comments.Add(comment6);

        Comment comment7 = new Comment();
        comment7._commentor = "Joe";
        comment7._commentText = "I am the one who replaced steve, and yes I miss Steve too";
        video2._comments.Add(comment7);


        Video video3 = new Video();
        video3._title = "Gotta catch them all";
        video3._author = "Pokemon";
        video3._length = 2000;

        Comment comment8 = new Comment();
        comment8._commentor = "Hannah";
        comment8._commentText = "This TV show is so nostalgic";
        video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._commentor = "David";
        comment9._commentText = "I havent seen Pikachu and Ash in such a long time";
        video3._comments.Add(comment9);

        Comment comment10 = new Comment();
        comment10._commentor = "Susan";
        comment10._commentText = "GOTTA CATCH THEM ALL, POKEMON!";
        video3._comments.Add(comment10);



        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);
        
        foreach(Video vid in videosList){
            vid.DisplayAll();
        }

        
    }
}