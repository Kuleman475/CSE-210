class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete)
    : base(name, description, points){
        _isComplete = complete;
    }
    
    // public override void RecordEvent(){

    // }
    // public override bool IsComplete(){

    // }
    public override string GetStringRepresetation(){
        Console.WriteLine($"{GetName()} {GetDescription()}");
        Console.WriteLine();
        return "POPOOPOPO";
    }
}