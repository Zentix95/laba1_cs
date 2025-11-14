using System;

namespace LibraryApp;

public class BookReturn
{
    public Book Book { get; }
    public Reader Reader { get; }
    public DateTime ReturnDate { get; }

    public BookReturn(Book book, Reader reader, DateTime date)
    {
        Book = book;
        Reader = reader;
        ReturnDate = date;
    }

    public override string ToString()
    {
        return $"Книга: {Book.Title}, Читатель: {Reader.Name}, Дата возврата: {ReturnDate.ToShortDateString()}";
    }
}