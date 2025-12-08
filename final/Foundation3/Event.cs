abstract class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public DateTime Date => _date;
    public TimeSpan Time => _time;

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\n" +
            $"Date: {_date:MMMM dd, yyyy}\nTime: {_time:hh\\:mm}\n" +
            $"Address: {_address.GetFullAddress()}";
    }
    
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}