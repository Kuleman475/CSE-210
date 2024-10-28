class Swimming : Activity {
    private double _laps;
    //lap in the pool is 50 meters.
    public Swimming(int minutes, string date, double laps) : base(minutes, date){
        _laps = laps;
    }
    public override double GetDistance(){
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    } 
    public override double GetSpeed(){
        double speed =  GetDistance() / GetMinutes() * 60;
        return speed;
    } 
    public override double GetPace(){
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetMinutes()}) - Distance {GetDistance()} Miles , Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
        return $"{GetDate()} Swimming ({GetMinutes()}) - Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}