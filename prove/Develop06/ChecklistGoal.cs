class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points){
        _amountCompleted = 1;
        _target = target;
        _bonus = bonus;

        Console.WriteLine(_amountCompleted + _bonus + _target);
    }

    // public override void RecordEvent(){

    // }
    // public override bool IsComplete(){

    // }
    // public string GetDetailsString(){

    // }
    // public override string GetStringRepresetation(){

    // }
}