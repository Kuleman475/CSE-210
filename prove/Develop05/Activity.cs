public class Activity {
    private string _name;
    private string _description;
    private int _duration{get; set;}

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public int GetDuration(){
        Console.WriteLine("How long would you like your session? ");
        string seconds = Console.ReadLine();
        int sec = Convert.ToInt32(seconds);
        _duration = sec;
        return sec;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        ShowSpinner();
        Console.Clear();
    }
    public void ShowSpinner(){
        for (int i = 0; i < 5; i++){
            Console.CursorVisible = false;
            
            Console.Write("\\ ");
            Thread.Sleep(250);
            Console.Write("\b\b\b"); 
            Console.Write("| ");
            Thread.Sleep(250);
            Console.Write("\b\b\b"); 
            Console.Write("/ ");
            Thread.Sleep(250);
            Console.Write("\b\b\b"); 
            Console.Write("- "); 
            Thread.Sleep(250);
            Console.Write("\b\b\b"); 
        }
        Console.CursorVisible = true;
    }
    public void ShowCountdown(int seconds){
        _duration = seconds;
        Console.Write("POP", seconds, _duration);
    }

}