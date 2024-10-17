public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description) 
    : base(name, description)
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        SetDuration(seconds);
        Run(seconds);
        DisplayEndingMessage();
    }

    public void Run(int seconds){
            Console.Clear();
            Console.WriteLine(seconds);
            Console.WriteLine("Get Ready...");
            Thread.Sleep(3000);        
            int time = 0;
        while(seconds > time) {
        for (int x = 5; x >= 0; x--){
            Console.Write("Breathe in ... " + x);
            Thread.Sleep(1000);
            Console.Clear();
            time += 1;
        }
        for (int x = 5; x >= 0; x--){
            Console.Write("Breathe out ... " + x);
            Thread.Sleep(1000);
            Console.Clear();
            time +=1;
        }
    }
    }
}