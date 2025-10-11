using System;
using System.Collections;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video(Comment _newComment)
    {
        _comments.Add(_newComment);
    }

    public void AddComents(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int NumComments()
    {
        int count = 0;

        foreach (Comment comment in _comments)
        {
            ++count;
        }

        return count;
    }  

    public void DisplayVideos()
    {
        Console.WriteLine("\nVideo Title: " + _title + "\nVido Author:" + _author + "\nLength: " + _length + " (mins)" + "\nNumber of Comments: " + NumComments());

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComments());
        }
    }
}