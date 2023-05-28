namespace Blogging.Models;

public class MarkdownFile
{
    private int _id;
    private string _data = "";
    private DateTime _createdAt = DateTime.Now;
    private DateTime _editedAt = DateTime.Now;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Data
    {
        get => _data;
        set
        {
            EditedAt = DateTime.Now;
            _data = value;
        }
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public DateTime EditedAt
    {
        get => _editedAt;
        set => _editedAt = value;
    }
}