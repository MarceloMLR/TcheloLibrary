namespace TcheloLibrary.Entities;

public enum Genero
{
    Ficção,
    Fanstasia,
    Terror,
    Romance,
    Suspense,
    Policial,
    Autoajuda
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public double Price { get; set; }
    public int StockQnt { get; set; }
}
