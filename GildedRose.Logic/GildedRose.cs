using GildedRose.Logic.Strategies;
using System.Collections.Generic;

namespace GildedRose.Logic
{
    public class GildedRose
    {
        IList<Item> items;
        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                StrategySelector.GetStrategy(item).Update(item);
            }
        }
    }
}
