using FluentAssertions;
using GildedRose.Logic;
using Xunit;


namespace GildedRose.Test
{
    public class ConjuredItemsTests : ItemsTestsBase
    {
        [Fact(DisplayName = "Conjured items also as standart items degrade in quality down to 0")]
        public void ConjuredItemsShouldDegradeInQualityLess0()
        {
            var intial = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(0);
        }

        //- "Conjured" items degrade in Quality twice as fast as normal items
        [Fact(DisplayName = "Conjured items degrade in Quality twice as fast as normal items")]
        public void ConjuredItemsShouldDegradeInQualityFaster()
        {
            var intial = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
            Execute(new[] { intial });
            intial.Quality.Should().Be(4);
        }
    }
}
