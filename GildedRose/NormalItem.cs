namespace GildedRose
{
    internal class NormalItem : Item, UpdateInterface
    {
        public NormalItem(string name, int SellIn, int quality)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn= SellIn;
        }

        void UpdateInterface.Update()
        {
            if (Quality > 0)
            {
                if (SellIn >= 0) Quality -= 1;
                else Quality -= 2;
            }

            SellIn--;
        }

    }
}
