using System.Reflection.Metadata;

public class Cycling:Activity {
    private double _speed;//I actually don't need this variable, I'm only using it because the assignment told me to track variables separately and demonstrate method overrides 
    public Cycling(double duration, double speed):base(duration, "Cycling", speed * duration / 60) 
    {
        _speed = speed;
    }
    public override double GetSpeed()//the base method GetSpeed works just fine because of the way I wrote the constructor. I am only writing this method to demonstrate method override per the assigment requirements 
    {
        return _speed;//mph
    }
}