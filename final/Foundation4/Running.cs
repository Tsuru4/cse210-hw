public class Running:Activity {
    //the rubic says so store the _distance field in the child class, not the base class. I politely but firmly disagree. _distance is applicable to every Activity
    public Running(double duration, double distance):base(duration,"Running",distance) 
    {
    }
}