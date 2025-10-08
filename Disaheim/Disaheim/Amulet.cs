using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemId;
        public string Design;
        public Level Quality;

        public Amulet()
        {
            ItemId = null;
            Design = null;
            Quality = Level.low;
        }

        public Amulet(string itemId)
        {
            ItemId = itemId;
            Design = null;
            Quality = Level.low;
        }

        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
            Quality = Level.low;
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString()
        {
            string text = $"Item ID: {ItemId}, Design: {Design}, Quality: {Quality}";
            return text;
        }

    }
}
