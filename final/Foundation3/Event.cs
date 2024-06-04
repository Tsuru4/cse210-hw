public abstract class Event{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _type;
    public Event(string title, string description, string date, string time, string address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    public string StandardDetails()
    {
        return $"\n{_title}: {_description}\n{_date} {_time}\n{_address}";
    }
    public abstract string FullDetails();
    public string ShortDescription()
    {
        return $"\n{_type}:\n{_title} {_date}";
    }
}