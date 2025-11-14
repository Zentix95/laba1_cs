namespace Library;

public class Book
{
    public string Id { get; }
    public string Title { get; set; }
    public string Author { get; set; }

    public int TotalCopies { get; private set; }
    public int AvailableCopies { get; private set; }

    private static int s_bookIdSeed = 1000;

    public Book(string title, string author, int totalCopies)
    {
        Id = s_bookIdSeed.ToString();
        s_bookIdSeed++;

        Title = title;
        Author = author;

        if (totalCopies <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(totalCopies), "Количество копий должно быть > 0");
        }

        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }

    public void Borrow()
    {
        if (AvailableCopies <= 0)
        {
            throw new InvalidOperationException("Пока книг нет в наличии");
        }
        AvailableCopies--;
    }

    public void Return()
    {
        if (AvailableCopies == TotalCopies)
        {
            throw new InvalidOperationException("Возвращать нечего, всё на месте");
        }
        AvailableCopies++;
    }

    public override string ToString()
    {
        return $"{Title} ({Author}) — доступно: {AvailableCopies}/{TotalCopies}";
    }
}
