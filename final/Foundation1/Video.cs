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
    public string GetVideo()
    {
        return $"{_title}, {_author}, {_length}, {_amountOfComments}";
    }
    public void addComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        commentList.Add(newComment);
    }
}