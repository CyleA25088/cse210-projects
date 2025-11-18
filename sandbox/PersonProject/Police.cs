using System.Globalization;

class Police : Person
{
    private string _weapons = "";

    public Police(string weapons, string FirstName, string LastName, int age, int weight)
    : base (FirstName, LastName, age, weight)
    {
        _weapons = weapons;
    }

    public string PolicePersonalInfo()
    {
        return $"{PersonalInfo()}, Weapons: {_weapons}";
    }
}
