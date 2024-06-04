using System.Reflection.PortableExecutable;

public abstract class Activity{
    private DateTime _date;
    private double _duration;
    private string _activityType;
    private double _distance;//The assignment says not to store unique attributes in the base class, but I insist that _distance is not a unique attribute. Distance, speed, and pace are applicable to all activities. It these were unique to the child class, we would not have methods in the base class that can determine these.
    public Activity(double duration, string activityType, double distance)
    {
        _date = DateTime.Now;
        _duration = duration;
        _activityType = activityType;
        _distance = distance;
    }
    protected double GetDuration()
    {
        return _duration;//minutes
    }
    public double GetDistance()
    {
        return _distance;//miles
    }
    public virtual double GetSpeed()//overwritting this method is unnessecary. I am only doing this so I can demonstrate that I understand how to use virtual and override methods.
    {
        return _distance / (_duration*60);//mph
    }
    public double GetPace()
    {
        return _duration / _distance;//minutes per mile
    }
    public string GetSummary()
    {
        // sample output from the instructions:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date.ToString("dd MMM yyyy")} {_activityType} ({_duration}min) Distance {GetDistance().ToString("N1")} miles, Speed {GetSpeed().ToString("N1")} mph, Pace: {GetPace().ToString("N1")} min per mile";
    }
}