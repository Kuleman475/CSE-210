public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int GetDuration(){
        // Console.WriteLine("How long would you like your session? ");
        // string seconds = Console.ReadLine();
        // int sec = Convert.ToInt32(seconds);
        // _duration = sec;
        return _duration;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like your session? ");
        string seconds = Console.ReadLine();
        int sec = Convert.ToInt32(seconds);
        _duration = sec;
    }
    public void DisplayEndingMessage(){

    }
    public void ShowSpinner(int seconds){
        _duration = seconds;
    }
    public void ShowCountdown(int seconds){
        _duration = seconds;
    }

}