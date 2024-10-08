using System;

public class Video{

    public string _title;
    public string _author;
    public int _length;

 //   Your program should have a class for a Video that has the responsibility to track 
 //   the title, author, and length (in seconds) of the video. 
 //   Each video also has responsibility to store a list of comments, and 
 //   should have a method to return the number of comments.
    public void DisplayAll(){
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);
    }
    public int numOfComments(){
        int i = 0;
        // foreach(int comment in _comments){
        //     i += 1;
        // }
        return i;
    }
}