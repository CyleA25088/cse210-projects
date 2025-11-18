class Program
{
    static void Main(string[] args)
    {
        Police myPerson = new Police("gun", "Name","Last", 22, 210);
        Doctor myDoctor = new Doctor("Scaple", "Name","Last", 22, 210);

        Console.WriteLine(myPerson.PersonalInfo());
        Console.WriteLine(myDoctor.PersonalInfo());
    }
}