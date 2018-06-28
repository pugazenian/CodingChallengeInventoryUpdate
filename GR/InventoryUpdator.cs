using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR
{
    /// <summary>
    /// Class responsible for updating the inventory - SellIn and Quality values
    /// </summary>
    public class InventoryUpdator
    {
        public IList<Item> Items;

        public InventoryUpdator(IList<Item> items)
        {
            Items = items;
        }

        public InventoryUpdator()
        { }

        public void UpdateInventory()
        {
            Console.WriteLine("Updating inventory");
            foreach (var item in Items)
            {
                Console.WriteLine(" - Item: {0}", item.Name);

                //Calling the strategycontext Which invokes the corresponding strategy based on item type
                UpdateInventoryContext.GetUpdatedInventory(item);
            }
            Console.WriteLine("Inventory update complete");
        }
    }
}
