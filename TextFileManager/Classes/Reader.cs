namespace LibraryApp;
public class Reader
{
    public int Id { get; }
    public string Name { get; }
    public Reader(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Имя: {Name}";
    }
}