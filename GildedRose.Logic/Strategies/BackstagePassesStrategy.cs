namespace GildedRose.Logic.Strategies
{
    /// <summary>
    /// - "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	/// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	/// Quality drops to 0 after the concert
    /// </summary>
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
