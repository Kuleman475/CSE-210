class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points){
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(){
        _amountCompleted += 1;
        if(_amountCompleted == _target){
            IsComplete();
        }
    }
    public override bool IsComplete(){
        return true;
    }
    public string GetDetailsString(){
        if(_amountCompleted == _target){
            return "X";
        }
        else {
            return " ";
        }
    }
    public override string GetStringRepresetation(){
        Console.WriteLine($"[{GetDetailsString()}] {GetName()} - ({GetDescription()}) -- {_amountCompleted}/{_target}");
        return $"[{GetDetailsString()}]::{GetName()}::({GetDescription()}::{_amountCompleted}::{_target}";
    }
}
