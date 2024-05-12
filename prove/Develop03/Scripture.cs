public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _ratio; //this works best as a number between 2 and 6, but some users may want to set a bigger ratio to make things easier for themselves if they feel intimidated.

    public Scripture(string referenceText, string scriptureText, int ratio)
    {
        ReConstruct(referenceText, scriptureText, ratio);
    }

    public Scripture(string referenceText, string scriptureText)
    {
        //this constructor is not currently in use, but is included as an option for programs that do not wish to specify the ratio
        ReConstruct(referenceText, scriptureText, 6);
    }

    private void ReConstruct(string referenceText, string scriptureText, int ratio)
    {
        //I feel that there is a better way to create a basic constructor, but I can't remember what it is. But this is useful for future use if I ever wish to reset the scripture, so I'm keeping this as is.
        _reference = new Reference(referenceText);
        _words = new List<Word>();
        GenerateWords(scriptureText);
        _ratio = ratio;
    }

    private void GenerateWords(string sentence)
    {
        string[] wordsArray = sentence.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void Write()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetText() + " ";
        }
        Console.WriteLine($"{_reference.GetReferenceText()}: {text}");
    }

    public bool IsRemainingWords()
    {
        foreach(Word word in _words)
        {
            if (word.IsVisible())
            {
                return true;
            }

        }
        return false;
    }

    public void HideRandom()
    {
        //ratio must be an integer greater or equal to 1, and 1 itself is not ideal because it sets a 100% probability
        Random random = new Random();
        foreach (Word word in _words)
        {
            if(random.Next(0,_ratio) == 0)
            {
                word.Hide();
            }
        }
    }
}