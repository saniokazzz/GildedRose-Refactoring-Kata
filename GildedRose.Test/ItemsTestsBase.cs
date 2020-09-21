using GildedRose.Logic;

namespace GildedRose.Test
{
    public abstract class ItemsTestsBase
    {
        public void Execute(Item[] items)
        {
            var app = new GildedRose.Logic.GildedRose(items);
            app.UpdateQuality();
        }
    }
}
