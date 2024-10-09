using System;

public class Video{

    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

 //   Your program should have a class for a Video that has the responsibility to track 
 //   the title, author, and length (in seconds) of the video. 
 //   Each video also has responsibility to store a list of comments, and 
 //   should have a method to return the number of comments.
    public void DisplayAll(){
        Console.WriteLine("");
        Console.WriteLine($"Title: '{_title}', Author: {_author}, Seconds: {_length}");
        Console.WriteLine($"Comments: {_comments.Count}");
            foreach(Comment comm in _comments){
                comm.DisplayComment();
            }
        
        
    }
}