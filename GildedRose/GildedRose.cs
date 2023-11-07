using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose {
        public IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            Initialize(items);
        }

        private void Initialize(IList<Item> list)
        {
            this.Items = new List<Item>();
            for (var i = 0; i < list.Count; i++)
            {
                Item currItem = list[i];
                Item specificItem = ItemFactory.CreateItem(currItem.Name, currItem.SellIn, currItem.Quality);
                Items.Add(specificItem);
            }
        }

        public void UpdateQuality() {
            for (var i = 0; i < Items.Count; i++)
            {
                Item currItem = Items[i];

                var itemUpdate = (UpdateInterface)currItem;
                itemUpdate.Update();

            }
        }
    }

}