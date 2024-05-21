using TcheloLibrary.Entities;

namespace TcheloLibrary;

public class Stock 
{
  public static List<Book> books = new List<Book>();

    static Stock()
    {
        books = new List<Book>();
    }
}
