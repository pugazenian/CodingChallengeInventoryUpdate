using GR.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR
{
    /// <summary>
    /// Class that reflects the Strategy Pattern (Behavioural pattern) implementation
    /// </summary>
    public class UpdateInventoryContext
    {
        private static readonly Dictionary<string, IUpdateInventoryStrategy> UpdateInventoryStrategies = new Dictionary<string, IUpdateInventoryStrategy>();
        
        // static constructor to hold the mapping of Items to strategy. This mapping needs to be loaded into memory before running the strategy. So decided to put in a static constructor
        static UpdateInventoryContext()
        {
            UpdateInventoryStrategies.Add(ItemCollections.AgedBrie, new AgedBrieUpdateInventoryStrategy());
            UpdateInventoryStrategies.Add(ItemCollections.BackstagePasses, new BackstageUpdateInventoryStrategy());
            UpdateInventoryStrategies.Add(ItemCollections.Sulfuras, new SulfurasUpdateInventoryStrategy());
            UpdateInventoryStrategies.Add(ItemCollections.Conjured, new ConjuredUpdateInventoryStrategy());
            UpdateInventoryStrategies.Add(ItemCollections.DefaultItems, new NormalItemsUpdateInventoryStrategy());
        }

        public static void GetUpdatedInventory(Item item)
        {

            // Checks if its a special item, else executes the default strategy for normal items(NormalItemsUpdateInventoryStrategy)
            if (UpdateInventoryStrategies.ContainsKey(item.Name))
            {
                UpdateInventoryStrategies[item.Name].GetUpdatedInventory(item);
            }
            else
            {
                UpdateInventoryStrategies[ItemCollections.DefaultItems].GetUpdatedInventory(item);   
            }
        }
    }
}
