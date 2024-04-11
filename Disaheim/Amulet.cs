using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string Design {  get; set; }
        public Level Quality {  get; set; }

        public Amulet(string itemId)
        {
        }
        public Amulet(string itemId, Level quality)
        {
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            Quality = quality;
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
