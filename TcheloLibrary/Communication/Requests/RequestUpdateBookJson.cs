using TcheloLibrary.Entities;

namespace TcheloLibrary.Communication.Requests
{
    public class RequestUpdateBookJson : Book
    {
  
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Author { get; set; } = string.Empty;
            public Genero Genero { get; set; }
            public double Price { get; set; } 
            public int StockQnt { get; set; }
        }
    }
}
