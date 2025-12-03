class EternalGoal : BaseGoal
{
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    override public string Serialize()
    {
        return $"EternalGoal|{base.Serialize()}|{_timesCompleted}";
    }

    override public void DisplayGoal()
    {
        Console.WriteLine($"[∞] {GetName()} ({GetDescription()}) - Completed {_timesCompleted} times");
    }

    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

    override public int RecordEvent()
    {
        _timesCompleted++;
        return GetPoints();
    }
}