using TcheloLibrary.Entities;

namespace TcheloLibrary.Communication.Requests
{

    public class RequestUpdateBookJson
    {

        public string Title { get; set; } = string.Empty;
        public  string Author { get; set; } = string.Empty;
        public Genero Genero { get; set; }
        public double Price { get; set; } 
        public int StockQnt { get; set; }
       
    }
}
