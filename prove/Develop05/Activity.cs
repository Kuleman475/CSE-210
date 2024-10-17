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
        // Console.WriteLine("How long would you like your session? ");
        // string seconds = Console.ReadLine();
        // int sec = Convert.ToInt32(seconds);
        // _duration = sec;
        // GetDuration();    
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
    }
    public void ShowSpinner(int seconds){
        _duration = seconds;
    }
    public void ShowCountdown(int seconds){
        _duration = seconds;
        Console.Write("POP", seconds, _duration);
    }

}