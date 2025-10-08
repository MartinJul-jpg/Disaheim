using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId;
        public string Title;
        public Double Price;

        public Book()
        {
            ItemId = null;
            Title = null;
            Price = 0;
        }
        
        public Book(string itemId)
        {
            ItemId = itemId;
            Title = null;
            Price = 0;
        }

        public Book(string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
            Price = 0;
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            string text = $"Item ID: {ItemId}, Title: {Title}, Price: {Price}";
            return text;
        }
    }
}