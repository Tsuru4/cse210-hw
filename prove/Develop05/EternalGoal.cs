public class EternalGoal:Goal {
    public EternalGoal(string name, string description, int points):base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    protected override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"eternal,{GetName()},{GetDescription()},{GetPoints()}";
    }

}