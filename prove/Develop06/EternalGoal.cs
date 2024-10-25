class EternalGoal : Goal {

    public EternalGoal(string name, string description, int points)
    :base (name, description, points){

    }

    public override void RecordEvent(){

    }
    public override bool IsComplete(){
        return false;
    }
    public override string GetStringRepresetation()
    {
        Console.WriteLine($"[ ] {GetName()} - ({GetDescription()})");
        return $"EternalGoal|[ ]|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}