using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    internal class ConjuredItem: Item, UpdateInterface
    {
        public ConjuredItem(string name, int SellIn, int quality)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn= SellIn;
        }

        void UpdateInterface.Update()
        {
            if (Quality > 0)
            {
                if (SellIn >= 0) Quality -= 2;
                else Quality -= 4;
            }

            SellIn--;
        }

}
}
