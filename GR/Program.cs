using System;
using System.Collections.Generic;

namespace GR
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            var inventoryUpdator = new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            //Class to update the SellIn value and Quality value
            inventoryUpdator.UpdateInventory();

            //Class to Write updated inventory details to a file. The responsibilities are seperated out to different files as per Single responsibility design principle
            var inventoryFileWriter = new InventoryFileWriter(inventoryUpdator.Items);
            inventoryFileWriter.Write();
            
            Console.ReadKey();
        }
    }
}