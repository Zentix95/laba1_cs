namespace LibraryApp;

public class Book
{
    public string ISBN { get; }
    public string Title { get; }
    public string Author { get; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ISBN: {ISBN}, Название: {Title}, Автор: {Author}";
    }
}