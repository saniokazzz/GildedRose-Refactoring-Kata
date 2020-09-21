namespace GildedRose.Logic.Strategies 
{
    /// <summary>
    /// - "Conjured" items degrade in Quality twice as fast as normal items
    /// </summary>
    public class ConjuredStrategy : StrategyBase
    {
        public ConjuredStrategy() : base(Constants.StandartDegradationVelocity * 2)
        {
        }
    }
}
