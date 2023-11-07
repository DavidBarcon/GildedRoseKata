using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    internal class SulfurasItem: Item, UpdateInterface
    {

        public SulfurasItem(string name, int quality, int SellIn)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn = SellIn;
        }

        void UpdateInterface.UpdateQuality()
        {
            Quality = Quality;
        }

        void UpdateInterface.UpdateSellIn()
        {
            SellIn = SellIn;
        }
    }
}
