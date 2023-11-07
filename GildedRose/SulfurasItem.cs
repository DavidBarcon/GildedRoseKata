using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    internal class SulfurasItem: Item, UpdateInterface
    {

        public SulfurasItem(string name, int SellIn, int quality)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn = SellIn;
        }

        void UpdateInterface.Update()
        {
            Quality = Quality;
            SellIn = SellIn;
        }
    }
}
