namespace GildedRose.Logic.Strategies
{
    /// <summary>
    /// - "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
    /// - "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.
    /// </summary>
    public class SulfurasStrategy : StrategyBase
    {
        protected override void UpdateSellInDate(Item item)
        {
        }

        protected override void UpdateQuality(Item item)
        {
        }
    }
}
