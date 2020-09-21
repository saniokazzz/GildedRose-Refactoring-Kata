
using FluentAssertions;
using GildedRose.Logic;
using Xunit;

namespace GildedRose.Test
{
    public class GuildedRoseTests : ItemsTestsBase
    {
        [Fact(DisplayName = "Algorithm transforms data same way as legacy")]
        public void ShouldTransformCollectionSameWayAsLegacy()
        {
            var items = new[] {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var expected = new[] {
                new Item {Name = "+5 Dexterity Vest", SellIn = -20, Quality = 0},
                new Item {Name = "Aged Brie", SellIn = -28, Quality = 50},
                new Item {Name = "Elixir of the Mongoose", SellIn = -25, Quality = 0},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = -15,
                    Quality = 0
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = -20,
                    Quality = 0
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = -25,
                    Quality = 0
                },
                new Item {Name = "Conjured Mana Cake", SellIn = -27, Quality = 0}
            };

            // 30 days here left intentionally, as original program outputs before executing algorithm
            for (var i = 0; i < 30; i++)
            {
                Execute(items);
            }

            items.Should().BeEquivalentTo(expected);
        }
    }
}
