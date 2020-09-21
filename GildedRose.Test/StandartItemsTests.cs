using FluentAssertions;
using GildedRose.Logic;
using Xunit;

namespace GildedRose.Test
{
    public class StandartItemsTests : ItemsTestsBase
    {
        [Fact(DisplayName = "Standart items quality is decreased by 1")]
        public void QualityIsDecreased()
        {
            var intial = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(19);
        }

        //- Once the sell by date has passed, Quality degrades twice as fast
        [Fact(DisplayName ="Standart items quality decreases twice as fast after sell date")]
        public void QualityIsDecreasedTwiceIfSellDatePasses()
        {
            var intial = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(18);
        }

        //- The Quality of an item is never negative
        [Fact(DisplayName = "Standart items quality is never negative")]
        public void QualityIsNeverNegative()
        {
            var intial = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(0);
        }
    }
}
