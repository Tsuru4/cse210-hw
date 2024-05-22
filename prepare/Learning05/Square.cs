public class Square:Shape{
    private double _side;
    public Square(double side, string color)
    {
        _side = side;
        _color = color;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}