using System.Runtime.CompilerServices;

public abstract class Goal {
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    protected int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }
    protected string GetDescription()
    {
        return _description;
    }
    public abstract int RecordEvent();
    protected abstract bool IsComplete();
    public virtual string GetStringDetails()
    {
        string checkbox = "[ ]";
        if (IsComplete())
            {
                checkbox = "[X]";
            }
        return $"{checkbox} {_shortName}, {_description}";
    }
    public abstract string GetStringRepresentation();    
}