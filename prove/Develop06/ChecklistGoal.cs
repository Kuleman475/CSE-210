class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
    : base(name, description, points){

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