using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    internal class PassItem: Item, UpdateInterface
    {

        public PassItem(string name, int SellIn, int quality)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn = SellIn;
        }

        void UpdateInterface.Update()
        {
            if (Quality < 50 )
            {
                //if sellIn is greter than 10, quality +1
                if (SellIn > 10) Quality += 1;

                //if sellIn is less than 10 , quality +1
                //if sellIn is less than 5 , additional quality +1
                if (SellIn <= 10 ) Quality += 1;
                if (SellIn <= 5) Quality += 1;
            }

            //if sellIn es less than 0, quality is 0
            if (SellIn < 0) Quality = 0;

            SellIn--;
        }
    }
}
