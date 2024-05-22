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

        public string? StockRemove(int id)
        {
            var removeBook = books.Find(book => book.Id == id);

            if (removeBook != null)
            {
                books.Remove(removeBook);
                return ("Livro removido do estoque");
            }
            
            return null;
        }

        public List<Book> StockGetAll()
        {
            return books;
        }

        public string? StockEdit(RequestCreateBookJson editBook)
        {
           var book = books.FirstOrDefault(b => b.Id == editBook.Id);

            
            if (book != null)
            {
                var bookType = book.GetType();
                var editBookType = editBook.GetType();

                foreach (var property in editBookType.GetProperties())
                {           
                    var value = property.GetValue(editBook);
                    if (value != null)
                    {
                        var bookProperty = bookType.GetProperty(property.Name);
                        if (bookProperty != null && bookProperty.CanWrite)
                        {
                            bookProperty.SetValue(book, value);
                        }
                    }
                }

                return ("Propriedades atualizadas");
            }

            return null;
        }
    }
}
