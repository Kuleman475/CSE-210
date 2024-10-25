class Goal {
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
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
    public virtual int GetBonus(){
        return 0;
    }

    public virtual void RecordEvent(){

    }
    public virtual bool IsComplete(){
        return false;
    }
    // public string GetDetailsString(){

    // }
    public virtual string GetStringRepresetation(){
        return $"{_shortName} : {_description}" +
        $"points {_points}";
    }
}