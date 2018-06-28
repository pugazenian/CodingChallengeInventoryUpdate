using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR
{
    /// <summary>
    /// Contains all the business rule boundary values
    /// </summary>
    public class BusinessRuleConstants
    {
        public const int NormalItemQualityMaxThreshold = 50;
        public const int NormalItemQualityMinThreshold = 0;
        public const int DefaultSellInThreshold = 0;
        public const int SulfurasQualityThreshold = 80;
        public const int ItemQualityDecreementValue = 1;
        public const int BackStagePassedDateBoundaryValue = 0;
        public const int BackStageFiveDayBoundary = 5;
        public const int BackStageTenDayBoundary = 10;
        public const int BackStageFiveDayBoundaryQualityIncreementValue = 3;
        public const int BackStageTenDayBoundaryQualityIncreementValue = 2;
    }
}
