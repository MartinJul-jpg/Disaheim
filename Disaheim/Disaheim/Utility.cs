using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double price = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    price = 12.5;
                    break;
                case Level.medium:
                    price = 20;
                    break;
                case Level.high:
                    price = 27.5;
                    break;
            }
            return price;
        }
    }
}
