class Goal {
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;

        Console.WriteLine($"{_shortName}\n{_description}\n{_points}");
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }


    // public string getGoalName(){
    //     Console.WriteLine(_shortName);
    //     return _shortName;
    // // }
    // public virtual void RecordEvent(){

    // }
    // public virtual bool IsComplete(){

    // }
    // public string GetDetailsString(){

    // }
    public virtual string GetStringRepresetation(){
        Console.WriteLine($"{_shortName} : {_description}" +
        $"points {_points}");
        return $"{_shortName} : {_description}" +
        $"points {_points}";
    }
}