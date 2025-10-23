using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            // Implementation for adding a book to the repository
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book book = books.FirstOrDefault(b => b.ItemId == itemId);
            return book;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Book book in books)
            {
                total = total + book.Price;
            }
            return total;
        }
    }
}
