public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    public Book(string newTitle, string newAuthor)
    {
        _title = newTitle;
        _author = newAuthor;
        _checkOutDate = "";
    }
    
    public void checkOut()
    {
        _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedOut()
    {
        bool IsCheckedOut;

        if (_checkOutDate == "")
        {
            IsCheckedOut = false;
        }
        else
        {
            IsCheckedOut = true;
        }

        return IsCheckedOut;
    }

    public void Display()
    {
        if (IsCheckedOut())
        {
            Console.WriteLine($"{_title} by {_author} check out: {_checkOutDate}");
        }

        Console.WriteLine($"{_title} by {_author}");
    }


}