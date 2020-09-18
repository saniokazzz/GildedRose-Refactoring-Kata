using System.Collections.Generic;
using GildedRose.Logic;
using Xunit;

namespace GildedRose.Test
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            Logic.GildedRose app = new Logic.GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("foo", items[0].Name);
        }
    }
}