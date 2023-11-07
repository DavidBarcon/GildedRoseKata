namespace GildedRose
{
    internal class BrieItem: Item, UpdateInterface
    {
        public BrieItem(string name, int SellIn, int quality)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn = SellIn;
        }

        void UpdateInterface.Update()
        {
            if (Quality < 50)
            {
                if (SellIn >= 0)
                {
                    Quality += 1;
                }
                else Quality += 2;
            }

            SellIn--;
        }

    }
}

