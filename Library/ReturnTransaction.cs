namespace Library;

public class ReturnTransaction
{
    public string ReaderId { get; }
    public string BookId { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public ReturnTransaction(string readerId, string bookId, DateTime date, string notes)
    {
        ReaderId = readerId;
        BookId = bookId;
        Date = date;
        Notes = notes;
    }
}
