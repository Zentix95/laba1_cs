using System;
using LibraryApp;

class Program
{
    static void Main()
    {
        var book1 = new Book("978-3-16-148410-0", "1984", "Джордж Оруэлл");
        var book2 = new Book("978-5-9909985-0-7", "Над пропастью во ржи", "Дэвид Сэлинджер");

        var reader1 = new Reader(1, "Миребекова Айдана");
        var reader2 = new Reader(2, "Соколов Тимофей");

        var loan1 = new BookLoan(book1, reader1, new DateTime(2025, 4, 1));
        var loan2 = new BookLoan(book2, reader2, new DateTime(2025, 4, 2));

        var return1 = new BookReturn(book1, reader1, new DateTime(2025, 4, 10));

        Console.WriteLine("=== Информация о книгах ===");
        Console.WriteLine(book1);
        Console.WriteLine(book2);

        Console.WriteLine("\n=== Информация о читателях ===");
        Console.WriteLine(reader1);
        Console.WriteLine(reader2);

        Console.WriteLine("\n=== Журнал выдачи ===");
        Console.WriteLine(loan1);
        Console.WriteLine(loan2);

        Console.WriteLine("\n=== Журнал возврата ===");
        Console.WriteLine(return1);
    }
}