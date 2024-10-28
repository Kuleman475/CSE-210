class Cycling : Activity {
    private double _speed;

    public Cycling(int minutes, string date, double speed) : base(minutes, date){
        _speed = speed;
    }
    public override double GetDistance(){
        double distance = _speed * GetMinutes() / 60;
        return distance;
    } 
    public override double GetSpeed(){
        return _speed;
    } 
    public override double GetPace(){
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetMinutes()}) - Distance {GetDistance()} Miles , Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
        return $"{GetDate()} Cycling ({GetMinutes()}) - Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}