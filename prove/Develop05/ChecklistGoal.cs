class CheckListGoal : BaseGoal
{

    private int targetCount;
    private int bonusPoints;
    private int currentCount;

    public CheckListGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    override public string Serialize()
    {
        return $"ChecklistGoal|{base.Serialize()}|{currentCount}|{targetCount}|{bonusPoints}";
    }

    override public void DisplayGoal()
    {
        string status = IsCompleted() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()}) - Completed {currentCount}/{targetCount} times");
    }

        public void SetCurrentCount(int counts)
    {
        currentCount = counts;
    }

    override public int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                MarkCompleted();
                return GetPoints() + bonusPoints;
            }
            return GetPoints();
        }

        return 0;
    }
}