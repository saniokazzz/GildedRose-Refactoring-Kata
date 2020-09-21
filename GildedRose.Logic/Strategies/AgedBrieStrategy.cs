namespace GildedRose.Logic.Strategies
{
    /// <summary>
    /// - Once the sell by date has passed, Quality degrades twice as fast
    /// - The Quality of an item is never more than 50
    /// - "Aged Brie" actually increases in Quality the older it gets
    /// </summary>
    public class AgedBrieStrategy : StrategyBase
    {
        public AgedBrieStrategy() : base(Constants.AgedBrieDegradationVelocity)
        {
        }
    }
}
