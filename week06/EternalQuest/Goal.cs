using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public string Name => _name;
    public string Description => _description;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string GetGoalType();

    public virtual string GetSaveData()
    {
        return $"{GetGoalType()}|{_name}|{_description}|{_points}";
    }

    public static Goal LoadFromData(string data)
    {
        var parts = data.Split('|');
        var type = parts[0];

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])),
            "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])),
            _ => throw new Exception("Unknown goal type.")
        };
    }
}
