using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    public class AmuletRepository
    {
        List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            // Implementation for adding a book to the repository
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet = amulets.FirstOrDefault(a => a.ItemId == itemId);
            return amulet;
        }

        public double GetTotalValue()
        {
            double total = 0;
            double price = 0;
            foreach (Amulet amulet in amulets)
            {
                price = 0;
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
                total = total + price;
            }
            return total;
        }
    }
}
