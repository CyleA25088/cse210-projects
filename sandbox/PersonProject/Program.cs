class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine($"{person.PersonalInfo()}, salary: {person.GetSalary()}");
    }

    static void Main(string[] args)
    {
        Police myPerson = new Police("gun", "Name","Last", 22, 210);
        Doctor myDoctor = new Doctor("Scaple", "Name","Last", 22, 210);
        Surgon mySurgon = new Surgon("Brain Doctor", "Scaple", "Name","Last", 22, 210);

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(mySurgon);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

}