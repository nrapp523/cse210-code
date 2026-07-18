class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> commentList = new List<Comment>();
    private int _amountOfComments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListInfo()
    {
        Console.WriteLine($"Video Title: {_title}, Author: {_author}, Time: {_length} seconds, Comments: {_amountOfComments}");
        Console.WriteLine("Comments:");
        foreach(Comment commentString in commentList)
        {
            commentString.GetText();
        }
    }
    public void addComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        commentList.Add(newComment);
        _amountOfComments += 1;
    }
    public int GetNumberOfComments()
    {
        return _amountOfComments;
    }
}