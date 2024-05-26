using System.Runtime.CompilerServices;

public class GoalManager {
    private List<Goal> _goals;
    private string _playerName = "default";
    private int _score = 0;

    public GoalManager(string playerName)
    {
        _playerName = playerName;
        _goals = new List<Goal>();
    }
    public string GetName()
    {
        return _playerName;
    }
    public int GetScore()
    {
        return _score;
    }
    public void Start()
    {
        string menuInput = "0";
        do
        {   
            
            if (menuInput == "-1")
            {
                Console.WriteLine("Invalid input. Please enter only the menu number.");
            }
            Console.WriteLine("Menu:\n1. Display player info\n2. List goal names\n3. List goal details\n4. Create new goal\n5. Record event\n6. Save goals\n7. Load goals\n8. Exit this menu");
            menuInput = Console.ReadLine();
            Console.Clear();
            if (menuInput == "1")
                {
                    DisplayPlayerInfo();
                }
            else if (menuInput == "2")
            {
                ListGoalNames();
            }
            else if (menuInput == "3")
            {
                ListGoalDetails();
            }
            else if (menuInput == "4")
            {
                CreateGoal();
            }
            else if (menuInput == "5")
            {
                RecordEvent();
            }
            else if (menuInput == "6")
            {
                SaveGoals();
            }
            else if (menuInput == "7")
            {
                LoadGoals();
            }
            else if (menuInput == "8")
            {}
            else
            {
                menuInput = "-1";
            }
        }while (menuInput != "8");
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_playerName}'s Score: {_score}");
    }
    private void ListGoalNames()
    {
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter += 1;
            Console.Write($"{counter} ");
            Console.WriteLine(goal.GetName());
        }
    }
    private void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringDetails());
        }
    }
    private void CreateGoal()
    {
        string goalType = "";
        Console.WriteLine("which kind of goal is this?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
        goalType = Console.ReadLine();
        while (goalType != "1" && goalType != "2" && goalType != "3")
        {
            Console.WriteLine("Invalid input. Please enter only the menu number.\n\nWhich kind of goal is this?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
            goalType = Console.ReadLine();
        }
        
        Console.WriteLine("Name the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Describe the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is completing this goal worth?");
        int points = int.Parse(Console.ReadLine());
        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        if (goalType == "3")
        {
            Console.WriteLine("How many times do you plan to repeat this goal?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many bonus points do you want when you have completed the goal {target} times?");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    private void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you complete? (enter the goal number only)");
        int goalCompleted = int.Parse(Console.ReadLine()) -1;
        if (goalCompleted < _goals.Count && goalCompleted >= 0)
        {
            _score += _goals[goalCompleted].RecordEvent();
        }
        else
        {
            Console.WriteLine("That number was outside your list.");
        }
    }
    private void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_playerName + ".txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            
        }
    }
    private void LoadGoals()
    {
        _goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(_playerName + ".txt");
        
        foreach (string line in lines)
        {
            string [] parts = line.Split(",");
            if (parts[0] == "eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "simple")
            {
                _goals.Add(new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4])));
            }
            else if (parts[0] == "checklist")
            {
                _goals.Add(new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6])));
            }
            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
}