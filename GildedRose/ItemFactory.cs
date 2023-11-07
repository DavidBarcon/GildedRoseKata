namespace GildedRose
{
    public class ItemFactory
    {
        public static Item CreateItem(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new BrieItem(name, sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new PassItem(name, sellIn, quality);
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasItem(name, 15, 80);
                default:
                    return new NormalItem(name, sellIn, quality);
            }
        }
    }
}
