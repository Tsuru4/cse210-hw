public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _ratio; //this works best as a number between 2 and 6, but some users may want to set a bigger ratio to make things easier for themselves if they feel intimidated.

    public Scripture(string referenceText, string scriptureText, int ratio)
    {
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