namespace GildedRose.Logic.Strategies
{
    public abstract class StrategyBase : IStrategy
    {
        protected const int MinQuality = 0;
        protected const int MaxQuality = 50;
        protected readonly int QualityDegradationVelocity;

        protected StrategyBase(int qualityDegradationVelocity = 0)
        {
            QualityDegradationVelocity = qualityDegradationVelocity;
        }

        protected virtual void UpdateSellInDate(Item item)
        {
            item.SellIn--;
        }

        protected virtual void UpdateQuality(Item item)
        {
            var degradationVelocity = item.SellIn >= 0 ? QualityDegradationVelocity : QualityDegradationVelocity * 2;
            item.Quality = (item.Quality - degradationVelocity).LimitToRange(MinQuality, MaxQuality);
        }

        public void Update(Item item)
        {
            UpdateSellInDate(item);
            UpdateQuality(item);
        }
    }
}
