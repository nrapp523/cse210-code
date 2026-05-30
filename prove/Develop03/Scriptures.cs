class Scriptures
{
    private string _verse;
    private List<string> _verseList = new List<string>();
    private List<int> _indexList = new List<int>();
    private int _randomIndex;


    public Scriptures(string verse)
    {
        _verse = verse;
        _verseList.AddRange(_verse.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
        for (int i = 0; i < _verseList.Count(); i++ )
        {
            _indexList.Add(i);
        }
    }
    public string GetVerse()
    {
        return _verse;
    }
    public List<string> GetVerseList()
    {
        return _verseList;
    }
    public List<int> GetIndexList()
    {
        return _indexList;
    }
    public int GetRandomIndex()
    {
        return _randomIndex;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
        _verseList.AddRange(_verse.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
        for (int i = 0; i < _verseList.Count(); i++ )
        {
            _indexList.Add(i);
        }
    }
    public void CreateRandomIndex()
    {
        int pickRandomIndex = Random.Shared.Next(_indexList.Count());
        _randomIndex = _indexList[pickRandomIndex];
        _indexList.RemoveAt(pickRandomIndex);
    }
    public void ReplaceWord()
    {
        //grab word from _verseList
        string indexWord = _verseList[_randomIndex];
        //construct object with indexWord
        Word wordChange = new Word(indexWord);
        //change indexWord to be made of dashes
        indexWord = wordChange.ReplaceWordWithDashes();
        //replace word in index list
        _verseList[_randomIndex] = indexWord;
    }
    public void UpdateVerse()
    {
        _verse = String.Join(" ",_verseList);
    }

}