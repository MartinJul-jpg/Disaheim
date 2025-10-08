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
            Quality = Level.medium;
        }

        public Amulet(string itemId)
        {
            ItemId = itemId;
            Design = null;
            Quality = Level.medium;
        }

        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
            Design = null;
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
