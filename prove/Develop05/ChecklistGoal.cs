using System;
public  class ChecklistGoal : Goal {
    private int _amountComplete;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = 0;
        _typeGoal = "ChecklistGoal";
    }
    public override void RecordEvent()
    //This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    //It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    {
        _amountComplete += 1;
    }

    public override bool IsComplete()
    //This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    {
        if (_amountComplete == _target)
        {
            
            return true;
        }
        else{;
            return false;
        }
    }
    public override string GetDetailsString()
    //This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. 
    //Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    {
        if (IsComplete())
        {
            _checkbox = "X";
        }
        return $"[{_checkbox}] {_shortName} ({_description}) -- Currently completed {_amountComplete}/{_target}";
    }
    public override string GetStringRepresentation()
    //This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"{_typeGoal},{_shortName},{_description},{_points},{_bonus},{_target},{_amountComplete}";
    }
    public void SetAmountComplete(int amountComplete)
    {
        _amountComplete = amountComplete;
    }


}