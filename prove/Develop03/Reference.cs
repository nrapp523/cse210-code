class Reference
{
    private string _book;
    private int _chapter;
    private int _sverse;
    private int _everse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _sverse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _sverse = startVerse;
        _everse = endVerse;
    }
    public void SetReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _sverse = startVerse;
        _everse = endVerse;
    }
    public void SetReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _sverse = startVerse;
    }
    public string GetReference()
    {
        if(_everse == 0)
        {
            return $"{_book} {_chapter}:{_sverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_sverse}-{_everse}";
        }
    }

    
}