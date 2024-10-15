public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description, int duration) 
    : base(name, description, duration)
    {
        DisplayStartingMessage();
        Console.WriteLine(duration + ":)");
    }

    public void Run(){
            Console.Clear();
            Console.WriteLine("Get Ready...");
            Thread.Sleep(3000);            
        for (int x = 5; x >= 0; x--){
            Console.Write("Breathe in ... " + x);
            Thread.Sleep(1000);
            Console.Clear();
        }
        for (int x = 5; x >= 0; x--){
            Console.Write("Breathe out ... " + x);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}