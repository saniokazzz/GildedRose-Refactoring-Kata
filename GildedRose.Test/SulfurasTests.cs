using FluentAssertions;
using GildedRose.Logic;
using Xunit;


namespace GildedRose.Test
{
    public class SulfurasTests : ItemsTestsBase
    {
        //- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        [Fact(DisplayName = "Sulfuras never has to be sold or decreases in Quality")]
        public void SulfurasHasNeverToBeSoldOrDecresedInQuality()
        {
            var intial = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 };
            Execute(new[] { intial });

            intial.SellIn.Should().Be(10);
            intial.Quality.Should().Be(80);
        }
    }
}
