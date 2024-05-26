using System.ComponentModel.DataAnnotations.Schema;

public class ChecklistGoal:Goal {
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted):base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        int points = GetPoints();
        _amountCompleted +=1;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You reached your target! You get {_bonus} bonus points this time!");
            points += _bonus;
        }
        return points;
    }
    protected override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringDetails()
    {
        string checkbox = "[ ]";
        if (IsComplete())
            {
                checkbox = "[ ]";
            }
        return $"{checkbox} {GetName()}, {GetDescription()} [{_amountCompleted}/{_target}]";
    }
    public override string GetStringRepresentation()
    {
        return $"checklist,{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }
}