abstract class BaseGoal
{
    private string _name;
    private int _points;
    private bool _isCompleted;
    public BaseGoal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;

    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _isCompleted;
    }

    public void MarkCompleted()
    {
        _isCompleted = true;
    }

    public abstract int RecordEvent();

    public virtual void DisplayGoal()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_points} points)");
    }

    public virtual int CalculatePoints()
    {
        return _points;
    }
}