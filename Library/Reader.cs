namespace Library;

public class Reader
{
    private static int s_readerIdSeed = 1;

    public string Id { get; }
    public string FullName { get; set; }

    private List<string> _borrowedBooks = new List<string>();

    public Reader(string fullName)
    {
        Id = s_readerIdSeed.ToString();
        s_readerIdSeed++;

        FullName = fullName;
    }

    public void TakeBook(string bookId)
    {
        _borrowedBooks.Add(bookId);
    }

    public void ReturnBook(string bookId)
    {
        if (!_borrowedBooks.Contains(bookId))
        {
            throw new InvalidOperationException("У вас нет долгов по этой книге");
        }

        _borrowedBooks.Remove(bookId);
    }

    public IEnumerable<string> GetBorrowedBooks()
    {
        return _borrowedBooks;
    }

    public override string ToString()
    {
        return $"Читатель {FullName} (ID={Id}) – книг на руках: {_borrowedBooks.Count}";
    }
}
