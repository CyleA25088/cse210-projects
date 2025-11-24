abstract class Person
{
    private string _firstName = "";
    private string _lastName = "";
    private int _age = 0;
    private int _weight = 0;
    public Person(string FirstName, string LastName, int age, int weight)
    {
        _firstName = FirstName;
        _lastName = LastName;
        
        SetAge(age);
        SetWeight(weight);
    }
    public virtual string PersonalInfo()
    {
        return $"{_lastName}, {_firstName} is {_age} year/s old, and weighs {_weight} lbs";
    }

    public abstract double GetSalary();
    public void SetAge(int age)
    {
        if(age<=0 || age > 300)
        return;

        _age = age;
    }

    public void SetWeight(int weight)
    {
        if(weight<=0 || weight > 500)
        return;
        
        _weight = weight;
    }
}