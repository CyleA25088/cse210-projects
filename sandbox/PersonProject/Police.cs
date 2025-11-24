using System.Globalization;

class Police : Person
{
    private string _weapons = "";

    public Police(string weapons, string FirstName, string LastName, int age, int weight)
    : base (FirstName, LastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string PersonalInfo()
    {
        return $"{base.PersonalInfo()}, Weapons: {_weapons}";
    }
    
    public override double GetSalary()
    {
        return 22.6;
    }
}
