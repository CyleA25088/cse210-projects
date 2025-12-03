class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    override public string Serialize()
    {
        return $"SimpleGoal|{base.Serialize()}|{(IsCompleted() ? 1 : 0)}";
    }

    override public int RecordEvent()
    {
        if (!IsCompleted())
        {
            MarkCompleted();
            return GetPoints();
        }
        return 0;
    }

    
    override public void DisplayGoal(){
        string status = IsCompleted() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()})");
    }
}