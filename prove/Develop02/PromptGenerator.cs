
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("What did you learn today? ");
        _prompts.Add("Whom did you serve? ");
        _prompts.Add("Have I done any good in the world today?" );
        _prompts.Add("Count your many blessing: ");
        _prompts.Add("Hast thou not seen how all though needest hast been granted in what He ordaineth? ");
        _prompts.Add("\"I said I never had known much of these things; but behold, I mistake\" Where have I seen the mysteries and power of the Lord today? ");
    }
    
    public string Generate()
    {
        Random random= new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }

}