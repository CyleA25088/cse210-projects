using System.Globalization;

class Surgon : Doctor
{
    private string _title = "";

    public Surgon(string title, string tools, string FirstName, string LastName, int age, int weight)
    : base (tools, FirstName, LastName, age, weight)
    {
        _title = title;
    }

    public string SurgonPersonalInfo()
    {
        Console.WriteLine("Surgon print:");

        return $"{PersonalInfo()}, Title: {_title}";
    }
}
