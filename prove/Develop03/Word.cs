using System.ComponentModel.DataAnnotations;

class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }
    public string ReplaceWordWithDashes()
    {
        string dashString = "";
        foreach (char letter in _word)
        {
            if (letter is '?' or '.' or ',' or '!')
            {
                dashString += letter;
            }
            else
            {
                dashString += "-";
            }
        }
        return dashString;
        
    }
}