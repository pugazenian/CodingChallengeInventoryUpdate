using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Strategies
{
    /// <summary>
    /// Strategy for Backstage items
    /// Test case 1: Sellin = Sellin-1;
    /// Test case 2: Sellin <=0, quality=0
    /// Test Case 3: SellIn <=5 and > 0, quality=quality+3
    /// Test case 4: Sellin >5 and <=10, quality=quality+2
    /// Test case 5: Sellin>10, quality=quality+1
    /// Test case 6: if Quality>50, quality=50
    /// </summary>
    public class BackstageUpdateInventoryStrategy : IUpdateInventoryStrategy
    {
        public void GetUpdatedInventory(Item item)
        {
            item.SellIn = --item.SellIn;
            var newQualityValue = item.Quality;
            if (item.SellIn <= BusinessRuleConstants.BackStagePassedDateBoundaryValue)
            {
                newQualityValue = BusinessRuleConstants.NormalItemQualityMinThreshold;
            }
            else if (item.SellIn <= BusinessRuleConstants.BackStageFiveDayBoundary)
            {
                newQualityValue = newQualityValue + BusinessRuleConstants.BackStageFiveDayBoundaryQualityIncreementValue;
            }
            else if (item.SellIn <= BusinessRuleConstants.BackStageTenDayBoundary)
            {
                newQualityValue = newQualityValue + BusinessRuleConstants.BackStageTenDayBoundaryQualityIncreementValue;
            }
            else
            {
                newQualityValue++;
            }
            item.Quality = newQualityValue >= BusinessRuleConstants.NormalItemQualityMaxThreshold ? BusinessRuleConstants.NormalItemQualityMaxThreshold : newQualityValue;
        }
    }
}
