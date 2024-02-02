using System;
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problem) : base(studentName, topic)
    {
        _textbookSection = section;
        _problems = problem;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}