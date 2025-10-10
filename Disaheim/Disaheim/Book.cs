using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        public string Title;
        public double Price;

        public Book(string itemId) : base()
        {
            ItemId = itemId;
            Title = string.Empty;
            Price = 0;
        }

        public Book(string itemId, string title) : base()
        {
            ItemId = itemId;
            Title = title;
            Price = 0;
        }

        public Book(string itemId, string title, double price) : base()
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            string text = $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
            return text;
        }
    }
}