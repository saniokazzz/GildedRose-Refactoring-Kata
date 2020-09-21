namespace GildedRose.Logic.Strategies
{
    public class StrategySelector
    {
        public static IStrategy GetStrategy(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieStrategy(),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesStrategy(),
                "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(),
                "Conjured Mana Cake" => new ConjuredStrategy(),
                _ => new StandardStrategy()
            };
        }
    }
}
