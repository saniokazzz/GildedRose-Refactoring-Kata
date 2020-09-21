using FluentAssertions;
using GildedRose.Logic;
using Xunit;

namespace GildedRose.Test
{
    public class AgedBrieTests : ItemsTests
    {
        //- "Aged Brie" actually increases in Quality the older it gets
        [Fact(DisplayName = "Aged Brie increases in quality over age")]
        public void QualityOfAgedBrieIsIncreased()
        {
            var intial = new Item { Name = "Aged Brie", SellIn = 10, Quality = 0 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(1);
        }

        //- The Quality of an item is never more than 50
        [Fact(DisplayName = "Quality of Aged Brie never passes 50")]
        public void QualityNeverMore50()
        {
            var intial = new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(50);
        }
    }
}
