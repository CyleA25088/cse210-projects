using System.Globalization;

class Doctor : Person
{
    private string _tools = "";

    public Doctor(string tools, string FirstName, string LastName, int age, int weight)
    : base (FirstName, LastName, age, weight)
    {
        _tools = tools;
    }

    public override string PersonalInfo()
    {
        return $"{base.PersonalInfo()}, Tools: {_tools}";
    }

    public override double GetSalary()
    {
        return 25.9;
    }
}
