using FluentAssertions;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class GildedRoseShould
    {
        [Test]
        public void never_reduce_quality_below_zero()
        {
            Item item = new Item() { Name = "x", Quality = 0, SellIn = 5 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(0);
        }

        [Test]
        public void never_increase_quality_above_50()
        {
            Item item = new Item() { Name = "Aged Brie", Quality = 50, SellIn = 5 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            item.Quality.Should().Be(50);
        }

        [Test]
        public void reduce_SellIn_if_item_is_not_sulfuras()
        {
            Item item = new Item() { Name = "x", Quality = 5, SellIn = 5 };
            Item brieItem = new Item() { Name = "Aged Brie", Quality = 5, SellIn = 5 };
            Item passItem = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 5, SellIn = 5 };

            List<Item> list = new List<Item>();
            list.Add(item);
            list.Add(brieItem);
            list.Add(passItem);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].SellIn.Should().Be(4);
            gildedRose.Items[1].SellIn.Should().Be(4);
            gildedRose.Items[2].SellIn.Should().Be(4);
        }

        [Test]
        public void never_change_sulfuras_quality_or_sellIn()
        {
            Item item = new Item() { Name = "Sulfuras, Hand of Ragnaros", Quality = 80, SellIn = 5 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            item.Quality.Should().Be(80);
            item.SellIn.Should().Be(5);
        }

        [Test]
        public void reduce_common_item_quality_by_1_when_a_day_passes_and_SellIn_is_greater_than_zero()
        {
            Item item = new Item() { Name = "x", Quality = 5, SellIn = 5 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(4);
        }

        [Test]
        public void increase_brie_quality_by_1_when_a_day_passes_and_SellIn_is_greater_than_zero()
        {
            Item item = new Item() { Name = "Aged Brie", Quality = 5, SellIn = 5 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(6);
        }

        [Test]
        public void reduce_common_item_quality_by_2_when_a_day_passes_and_SellIn_is_less_than_zero()
        {
            Item item = new Item() { Name = "x", Quality = 5, SellIn = -1 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(3);
        }

        [Test]
        public void increase_brie_item_quality_by_2_when_a_day_passes_and_SellIn_is_less_than_zero()
        {
            Item item = new Item() { Name = "Aged Brie", Quality = 5, SellIn = -1 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(7);
        }

        [Test]
        public void increase_pass_item_quality_by_1_when_SellIn_is_more_than_10()
        {
            Item item = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 5, SellIn = 11 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(6);
        }

        [Test]
        public void increase_pass_item_quality_by_2_when_SellIn_is_less_than_10()
        {
            Item item = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 5, SellIn = 9 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(7);
        }

        [Test]
        public void increase_pass_item_quality_by_3_when_SellIn_is_less_than_5()
        {
            Item item = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 5, SellIn = 3 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(8);
        }

        [Test]
        public void pass_quality_is_0_when_SellIn_is_less_than_0()
        {
            Item item = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 5, SellIn = -1 };
            List<Item> list = new List<Item>();
            list.Add(item);

            var gildedRose = new GildedRose(list);
            gildedRose.UpdateQuality();

            gildedRose.Items[0].Quality.Should().Be(0);
        }


    }
}