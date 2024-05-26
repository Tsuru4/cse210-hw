public class SimpleGoal:Goal {
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points):base(name, description, points)
    {
    }
    public SimpleGoal(string name, string description, int points, bool isComplete):base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
        _isComplete = true;
        return GetPoints();
        }
        else
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
    }
    protected override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"simple,{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}