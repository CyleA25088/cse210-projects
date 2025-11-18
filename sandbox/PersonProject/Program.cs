class Program
{
    static void Main(string[] args)
    {
        Police myPerson = new Police("gun", "Name","Last", 22, 210);
        Doctor myDoctor = new Doctor("Scaple", "Name","Last", 22, 210);
        Surgon mySurgon = new Surgon("Brain Doctor", "Scaple", "Name","Last", 22, 210);

        Console.WriteLine(myPerson.PolicePersonalInfo());
        Console.WriteLine(myDoctor.DoctorPersonalInfo());
        Console.WriteLine(mySurgon.SurgonPersonalInfo());
    }
}