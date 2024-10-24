class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete)
    : base(name, description, points){
        _isComplete = complete;
    }
    
    public override void RecordEvent(){

    }
    public override bool IsComplete(){
        _isComplete = true;
        return true;
    }
    public string CheckComplete(){
        if (_isComplete == true){
            return "X";
        }
        else{
            return " ";
        }
    }
    public override string GetStringRepresetation(){
        Console.WriteLine($"[{CheckComplete()}] {GetName()} - ({GetDescription()})");
        return $"[{CheckComplete()}] {GetName()} - ({GetDescription()})";
    }
}