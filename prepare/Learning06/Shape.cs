class Shape {
    private string _color;

    public Shape(string color){
        _color = color;
    }
    public string GetColor(){
        Console.WriteLine(_color);
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }

    public virtual double GetArea(){
        Console.WriteLine("Shape");
        return 0;
    }

}