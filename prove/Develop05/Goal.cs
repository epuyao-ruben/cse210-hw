using System;
public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _checkbox = " ";
    protected string _typeGoal;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    //This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. 
    //Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    {
        if (IsComplete())
        {
            _checkbox = "X";
        }
        return $"[{_checkbox}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();




}