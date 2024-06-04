public class OutdoorGathering:Event{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, string address, string weather):base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        string details = "\nOutdoor Gathering:";
        details += StandardDetails();
        details += $"\nThe weather forecast is {_weather}.";
        return details;
    }
}