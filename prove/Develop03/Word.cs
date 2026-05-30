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
        for (int i = 0; i < _word.Length; i++)
        {
            dashString += "-";
        }
        return dashString;
    }
}