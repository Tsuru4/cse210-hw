public class Word
{  
    private string _text;
    private bool _isVisible = true;
    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isVisible = false;
    }

    public bool IsVisible()
    {
        return _isVisible;
    }

    public string GetText()
    {
        if (_isVisible)
        {
            return _text;
        }
        else
        {
            string blankString = "";
            for (int i = 0; i < _text.Length;i++)
            {
                blankString += "_";
            }
            return blankString;
        }
    }
}