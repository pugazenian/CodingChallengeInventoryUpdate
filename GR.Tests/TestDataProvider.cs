using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Tests
{
    public class TestDataProvider
    {
        public static InventoryUpdator DexterityVest_ShouldDecreaseByone_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 1},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item
                    {
                        Name = "Backstage passes to a D498FJ9FJ2N concert",
                        SellIn = 10,
                        Quality = 30
                    },
                    new Item
                    {
                        Name = "Backstage passes to a FH38F39DJ39 concert",
                        SellIn = 5,
                        Quality = 33
                    },
                    new Item
                    {
                        Name = "Backstage passes to a I293JD92J44 concert",
                        SellIn = 6,
                        Quality = 27
                    },
                    new Item
                    {
                        Name = "Backstage passes to a O2848394820 concert",
                        SellIn = 1,
                        Quality = 13
                    },
                    new Item
                    {
                        Name = "Backstage passes to a DEEEADMEEET concert",
                        SellIn = 0,
                        Quality = 25
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };
        }

        public static InventoryUpdator DexterityVest_SellInOne_Quality_ShouldDecreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 1, Quality = 20}
                }
            };
        }

        public static InventoryUpdator DexterityVest_SellInZero_Quality_ShouldDecreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20}
                }
            };
        }

        public static InventoryUpdator DexterityVest_SellInGreaterThanZero_Quality_ShouldDecreaseByOne_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 2, Quality = 20}
                }
            };
        }


        public static InventoryUpdator DexterityVest_SellInGreaterThanZero_QualityIsZero_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 2, Quality = 0}
                }
            };
        }

        //Conjured Test data

        public static InventoryUpdator Conjured_SellinIsOne_Quality_ShouldDecreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Conjured_SellinIsZero_Quality_ShouldDecreaseByFour_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Conjured Mana Cake", SellIn = 1, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Conjured_SellinIsNegative_Quality_ShouldDecreaseByFour_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Conjured_SellinIsNegative_QualityIsNegative_ShouldBecomeZero_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 0}
                }
            };
        }


        //Sulfuras test data
        
        public static InventoryUpdator Sulfuras_SellinIsZero_QualityIsEighty_ShouldNotChange_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
                }
            };
        }

        //AgedBrie Test data

        public static InventoryUpdator AgedBrie_SellinIsOne_Quality_ShouldIncreaseByOne_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Aged Brie", SellIn = 1, Quality = 10}
                }
            };
        }

        public static InventoryUpdator AgedBrie_SellinIsOne_QualityIsFifty_ShouldBeFifty_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Aged Brie", SellIn = 1, Quality = 50}
                }
            };
        }

        //Backstage test data
        public static InventoryUpdator Backstage_SellinIsBetweenOneAndFive_Quality_ShouldIncreaseByThree_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsFive_Quality_ShouldIncreaseByThree_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsBetweenSixAndTen_Quality_ShouldIncreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsTen_Quality_ShouldIncreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsGreaterThanTen_Quality_ShouldIncreaseByOne_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsZero_Quality_ShouldBecomeZero_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsNegative_Quality_ShouldBecomeZero_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 10}
                }
            };
        }

        public static InventoryUpdator Backstage_SellinIsGreaterThanTen_QualityIsGreaterThanFifty_ShouldBeFifty_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 50}
                }
            };
        }


        // Elixir test data
        public static InventoryUpdator Elixir_ShouldDecreaseByone_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 1},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
                }
            };
        }

        public static InventoryUpdator Elixir_SellInOne_Quality_ShouldDecreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Elixir of the Mongoose", SellIn = 1, Quality = 20}
                }
            };
        }

        public static InventoryUpdator Elixir_SellInZero_Quality_ShouldDecreaseByTwo_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Elixir of the Mongoose", SellIn = 0, Quality = 20}
                }
            };
        }

        public static InventoryUpdator Elixir_SellInGreaterThanZero_Quality_ShouldDecreaseByOne_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Elixir of the Mongoose", SellIn = 2, Quality = 20}
                }
            };
        }


        public static InventoryUpdator Elixir_SellInGreaterThanZero_QualityIsZero_Data()
        {
            return new InventoryUpdator
            {
                Items = new List<Item>
                {
                    new Item {Name = "Elixir of the Mongoose", SellIn = 2, Quality = 0}
                }
            };
        }

               
    }
}
