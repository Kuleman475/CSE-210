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
            Console.WriteLine("Get Ready...");
            ShowSpinner();   
            Console.Clear();  
            int time = 0;
        while(seconds > time) {
        
        Console.Write("\nBreathe in ... ");
        for (int x = 5; x >= 0; x--){
             Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b");
            time += 1;
        }

        Console.Write("\n\nNow breathe out ... "); 
        for (int x = 5; x >= 0; x--){
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b");
            time +=1;
        }
    }
    Console.WriteLine("\n\nGreat Job!\n");
    }
}