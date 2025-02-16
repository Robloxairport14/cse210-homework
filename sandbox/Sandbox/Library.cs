public class Library
{
    private List<Book> _books;

    public Library()
    {
        _books = new List<Book>();
    }
    public void addBook(Book theBook)
    {
        _books.Add(theBook);
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("The catalog is:");

        foreach (Book b in _books)
        {
            b.Display();
        }
    }

}