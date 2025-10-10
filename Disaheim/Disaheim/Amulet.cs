using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string ItemId;
        public string Design;
        public Level Quality;


        public Amulet(string itemId) : base()
        {
            ItemId = itemId;
            Design = null;
            Quality = Level.medium;
        }

        public Amulet(string itemId, Level quality) : base()
        {
            ItemId = itemId;
            Quality = quality;
            Design = null;
        }

        public Amulet(string itemId, Level quality, string design) : base()
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
