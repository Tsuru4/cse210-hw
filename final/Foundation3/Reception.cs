using System.ComponentModel.DataAnnotations;

public class Reception:Event{
    private string _email;
    public Reception(string title, string description, string date, string time, string address, string email):base(title, description, date, time, address, "Reception")
    {
        _email = email;
    }
    public override string FullDetails()
    {
        string details = "\nReception:";
        details += StandardDetails();
        details += $"\nRSVP at {_email}.";
        return details;
    }
}