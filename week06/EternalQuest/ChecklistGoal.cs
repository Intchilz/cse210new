using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have completed the checklist goal '{_name}' and earned {_bonusPoints} bonus points!");
            return _points + _bonusPoints;
        }
        else
        {
            Console.WriteLine($"Progress recorded: {_currentCount}/{_targetCount} for '{_name}'.");
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }

    public override string GetSaveData()
    {
        return $"{GetGoalType()}|{_name}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }
}
//