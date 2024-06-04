public class Swimming:Activity{
    private double _laps;//the assignment told us to track this variable, but it's much simpler to track convert it to distance one time and then use distance and the base methods. The client doesn't even request to see the number of laps at any point, so we are being asked to track an unnessecary field
    public Swimming(double duration, double laps):base(duration, "Swimming", laps * 50 / 1000 * 0.62)
    {
        _laps = laps;   
    }
}