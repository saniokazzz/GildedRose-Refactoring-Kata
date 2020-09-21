using FluentAssertions;
using GildedRose.Logic;
using Xunit;

namespace GildedRose.Test
{
    public class BackstagePassesTestsData
    {
        public static TheoryData<Item, int> Data => new TheoryData<Item, int> {
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }, 21 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 }, 22 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 20 }, 22 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 }, 23 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 20 }, 23 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 20 }, 23 },
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -2, Quality = 20 }, 0 }
        };
    }

    public class BackstagePassesTests : ItemsTestsBase
    {
        //- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	    // Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	    // Quality drops to 0 after the concert
        [Theory(DisplayName = "Backstage passes increases in Quality as its SellIn value approaches and drops to 0 after the concert")]
        [MemberData(nameof(BackstagePassesTestsData.Data), MemberType = typeof(BackstagePassesTestsData))]
        public void QualityIsChangingAccordingToSellInDate(Item item, int expectedQuality)
        {
            var expectedSellInDate = item.SellIn - 1;
            Execute(new[] { item });

            item.SellIn.Should().Be(expectedSellInDate);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
