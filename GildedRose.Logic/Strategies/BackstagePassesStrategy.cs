namespace GildedRose.Logic.Strategies
{
    public class BackstagePassesStrategy : StrategyBase
    {
        protected override void UpdateQuality(Item item)
        {
            var quality = item.SellIn switch
            {
                int sellInDate when sellInDate < 0 => 0,
                int sellInDate when sellInDate < 5 => item.Quality + 3,
                int sellInDate when sellInDate < 10 => item.Quality + 2,
                _ => item.Quality + 1
            };

            item.Quality = quality.LimitToRange(MinQuality, MaxQuality);
        }
    }
}
