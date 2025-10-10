﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public List<Merchandise> Books;
        public List<Merchandise> Amulets;

        public Controller()
        {
            Books = new List<Merchandise>();
            Amulets = new List<Merchandise>();
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
