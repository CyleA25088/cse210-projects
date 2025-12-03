abstract class BaseGoal
{
    private string _name;
    private int _points;
    private bool _isCompleted;
    private string _description;
    public BaseGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;

    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
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

    public virtual string Serialize()
    {
        return $"{_name}|{_description}|{_points}";
    }

    public abstract void DisplayGoal();

    public virtual int CalculatePoints()
    {
        return _points;
    }
}