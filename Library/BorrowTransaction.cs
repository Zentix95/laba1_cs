namespace Library;

public class BorrowTransaction
{
    public string ReaderId { get; }
    public string BookId { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public BorrowTransaction(string readerId, string bookId, DateTime date, string notes)
    {
        ReaderId = readerId;
        BookId = bookId;
        Date = date;
        Notes = notes;
    }
}
