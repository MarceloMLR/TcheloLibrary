using TcheloLibrary.Communication.Requests;
using TcheloLibrary.Entities;

namespace TcheloLibrary
{
    public class StockMethods : Stock
    {
        public string? StockAdd(Book newBook)
        {
            if (books.Any(book => book.Id == newBook.Id)) {
                return null;
            }

            books.Add(newBook);
            return("Livro Adicionado");
        }

        public string StockRemove(int id)
        {
            if (books.Any(book => book.Id == id))
            {
                return ($"O id informado não existe");
            }
            books.RemoveAt(id);
            return ("Livro removido");
        }

        public List<Book> StockGetAll()
        {
            return books;
        }

        public void StockEdit(RequestCreateBookJson editBook)
        {
           var book = books.FirstOrDefault(b => b.Id == editBook.Id);

            if(book != null)
            {

            }

            
        }
    }
}
