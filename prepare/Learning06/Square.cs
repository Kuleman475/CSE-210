class Square : Shape {
    private double _side;

    public Square(string color, double side) : base(color){
        _side = side;
    }
    public override double GetArea(){
        Console.WriteLine(_side * _side);
        return _side * _side;
    }
}