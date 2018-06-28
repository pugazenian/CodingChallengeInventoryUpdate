using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Strategies
{
    public class SulfurasUpdateInventoryStrategy : IUpdateInventoryStrategy
    {
        /// <summary>
        /// Strategy for Sulfuras items
        /// Test case 1: Sellin = 0;
        /// Test Case 2: quality=80
        /// </summary>
        public void GetUpdatedInventory(Item item)
        {
            item.Quality = BusinessRuleConstants.SulfurasQualityThreshold;
            item.SellIn = BusinessRuleConstants.DefaultSellInThreshold;
        }
    }
}
