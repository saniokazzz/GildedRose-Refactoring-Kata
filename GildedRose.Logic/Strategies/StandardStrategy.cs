namespace GildedRose.Logic.Strategies
{
    /// <summary>
    /// - Once the sell by date has passed, Quality degrades twice as fast
    /// - The Quality of an item is never negative
    /// - The Quality of an item is never more than 50
    /// </summary>
    public class StandardStrategy : StrategyBase
    {
        public StandardStrategy() : base(Constants.StandartDegradationVelocity)
        {
        }
    }
}
