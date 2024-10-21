class Circle : Shape {
    
    private double _radius;

    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    public override double GetArea(){
        Console.WriteLine(_radius * _radius * 3.14159);
        return _radius * _radius * 3.14159;
    }
}