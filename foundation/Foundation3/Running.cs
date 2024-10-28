class Running : Activity {
    private double _distance;

    public Running(int minutes, string date, double distance) : base(minutes, date){
        _distance = distance;
    }
    public override double GetDistance(){
        return _distance;
    } 
    public override double GetSpeed(){
        double speed = _distance / GetMinutes() * 60;
        return speed;
    } 
    public override double GetPace(){
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetMinutes()}) - Distance {GetDistance()} Miles , Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
        return $"{GetDate()} Running ({GetMinutes()}) - Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}