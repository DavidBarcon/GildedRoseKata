namespace GildedRose
{
    internal class NormalItem : Item, UpdateInterface
    {
        public NormalItem(string name, int quality, int SellIn)
        {
            this.Name = name;
            this.Quality = quality;
            this.SellIn= SellIn;
        }

        void UpdateInterface.UpdateQuality()
        {
            if (Quality > 0)
            {
                if (SellIn >= 0) Quality -= 1;
                else Quality -= 2;
            }
        }

        void UpdateInterface.UpdateSellIn()
        {
            SellIn--;
        }
    }
}
