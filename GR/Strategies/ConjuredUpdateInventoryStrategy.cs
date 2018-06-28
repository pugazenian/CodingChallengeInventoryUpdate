using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Strategies
{
    public class ConjuredUpdateInventoryStrategy : IUpdateInventoryStrategy
    {
        /// <summary>
        /// Strategy for Conjured items
        /// Test case 1: Sellin = Sellin-1;
        /// Test case 2: if selling<=0, quality= quality-4
        /// Test case 3: if selling>0, quality= quality-2
        /// Test Case 4: if quality<0, quality=0
        /// </summary>
        public void GetUpdatedInventory(Item item)
        {
            item.SellIn = --item.SellIn;
            var newQualityValue = item.Quality - (item.SellIn <= 0 ? 4 * BusinessRuleConstants.ItemQualityDecreementValue : 2 * BusinessRuleConstants.ItemQualityDecreementValue);
            item.Quality = newQualityValue < BusinessRuleConstants.NormalItemQualityMinThreshold ? BusinessRuleConstants.NormalItemQualityMinThreshold : newQualityValue;
        }
    }
}
