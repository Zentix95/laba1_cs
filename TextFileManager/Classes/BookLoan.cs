using System;
namespace LibraryApp;
public class BookLoan
{
    public Book Book { get; }
    public Reader Reader { get; }
    public DateTime LoanDate { get; }

    public BookLoan(Book book, Reader reader, DateTime date)
    {
        Book = book;
        Reader = reader;
        LoanDate = date;
    }
    public override string ToString()
    {
        return $"Книга: {Book.Title}, Читатель: {Reader.Name}, Дата выдачи: {LoanDate.ToShortDateString()}";
    }
}