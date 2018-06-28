using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Strategies
{
    /// <summary>
    /// Strategy for Aged Brie items
    /// Test case 1: Sellin = Sellin-1;
    /// Test case 2: quality= quality+1
    /// Test Case 3: if quality>50, quality=50
    /// </summary>
    public class AgedBrieUpdateInventoryStrategy: IUpdateInventoryStrategy
    {
        public void GetUpdatedInventory(Item item)
        {
            item.SellIn = --item.SellIn;
            item.Quality = ++item.Quality >= BusinessRuleConstants.NormalItemQualityMaxThreshold ? BusinessRuleConstants.NormalItemQualityMaxThreshold : item.Quality;
        }
    }
}
