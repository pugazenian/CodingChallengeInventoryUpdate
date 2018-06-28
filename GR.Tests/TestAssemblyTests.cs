using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class TestAssemblyTests
    {
        public TestAssemblyTests()
        {

        }

        [Fact]
        public void DexterityVest_SellIn_ShouldDecreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_ShouldDecreaseByone_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(9, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
        }

        [Fact]
        public void DexterityVest_Quality_ShouldDecreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_ShouldDecreaseByone_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(19, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        [Fact]
        public void DexterityVest_SellinIsOne_ShouldDecreaseToZero()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInOne_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
        }

        [Fact]
        public void DexterityVest_SellinIsZero_Quality_ShouldDecreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInOne_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(18, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        [Fact]
        public void DexterityVest_SellinIsZero_ShouldBecomeNegative()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInZero_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(-1, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
        }

        [Fact]
        public void DexterityVest_SellinIsNegative_Quality_ShouldDecreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInZero_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(18, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        [Fact]
        public void DexterityVest_SellinGreaterThanZero_Quality_ShouldDecreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInGreaterThanZero_Quality_ShouldDecreaseByOne_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(1, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
            Assert.Equal(19, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        [Fact]
        public void DexterityVest_SellInGreaterThanZero_QualityIsZero_ShouldBeZero()
        {
            var _inventoryUpdator = TestDataProvider.DexterityVest_SellInGreaterThanZero_QualityIsZero_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(1, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        //Conjured Test cases

        [Fact]
        public void Conjured_SellinIsOne_Quality_ShouldDecreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.Conjured_SellinIsOne_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(1, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").SellIn);
            Assert.Equal(8, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }

        [Fact]
        public void Conjured_SellinIsZero_Quality_ShouldDecreaseByFour()
        {
            var _inventoryUpdator = TestDataProvider.Conjured_SellinIsZero_Quality_ShouldDecreaseByFour_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").SellIn);
            Assert.Equal(6, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }

        [Fact]
        public void Conjured_SellinIsNegative_Quality_ShouldDecreaseByFour()
        {
            var _inventoryUpdator = TestDataProvider.Conjured_SellinIsNegative_Quality_ShouldDecreaseByFour_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(-2, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").SellIn);
            Assert.Equal(6, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }

        [Fact]
        public void Conjured_SellinIsNegative_QualityIsNegative_ShouldBecomeZero()
        {
            var _inventoryUpdator = TestDataProvider.Conjured_SellinIsNegative_QualityIsNegative_ShouldBecomeZero_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(-2, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").SellIn);
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }


        //Sulfuras test cases

        [Fact]
        public void Sulfuras_SellinIsZero_QualityIsEighty_ShouldNotChange()
        {
            var _inventoryUpdator = TestDataProvider.Sulfuras_SellinIsZero_QualityIsEighty_ShouldNotChange_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Sulfuras, Hand of Ragnaros").SellIn);
            Assert.Equal(80, _inventoryUpdator.Items.First(x => x.Name == "Sulfuras, Hand of Ragnaros").Quality);
        }


        //AgedBrie Test cases

        [Fact]
        public void AgedBrie_SellinIsOne_Quality_ShouldIncreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.AgedBrie_SellinIsOne_Quality_ShouldIncreaseByOne_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Aged Brie").SellIn);
            Assert.Equal(11, _inventoryUpdator.Items.First(x => x.Name == "Aged Brie").Quality);
        }

        [Fact]
        public void AgedBrie_SellinIsOne_QualityIsFifty_ShouldBeFifty()
        {
            var _inventoryUpdator = TestDataProvider.AgedBrie_SellinIsOne_QualityIsFifty_ShouldBeFifty_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Aged Brie").SellIn);
            Assert.Equal(50, _inventoryUpdator.Items.First(x => x.Name == "Aged Brie").Quality);
        }


        //Backstage test cases

        [Fact]
        public void Backstage_SellinIsBetweenOneAndFive_Quality_ShouldIncreaseByThree()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsBetweenOneAndFive_Quality_ShouldIncreaseByThree_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(2, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(13, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsFive_Quality_ShouldIncreaseByThree()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsFive_Quality_ShouldIncreaseByThree_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(5, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(13, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsBetweenSixAndTen_Quality_ShouldIncreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsBetweenSixAndTen_Quality_ShouldIncreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(7, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(12, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsTen_Quality_ShouldIncreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsTen_Quality_ShouldIncreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(10, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(12, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsGreaterThanTen_Quality_ShouldIncreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsGreaterThanTen_Quality_ShouldIncreaseByOne_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(19, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(11, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsZero_Quality_ShouldBecomeZero()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsZero_Quality_ShouldBecomeZero_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsNegative_Quality_ShouldBecomeZero()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsNegative_Quality_ShouldBecomeZero_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(-2, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Backstage_SellinIsGreaterThanTen_QualityIsGreaterThanFifty_ShouldBeFifty()
        {
            var _inventoryUpdator = TestDataProvider.Backstage_SellinIsGreaterThanTen_QualityIsGreaterThanFifty_ShouldBeFifty_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(11, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
            Assert.Equal(50, _inventoryUpdator.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }


        // Elixir test cases 

        [Fact]
        public void Elixir_SellinIsOne_ShouldDecreaseToZero()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInOne_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").SellIn);
        }

        [Fact]
        public void Elixir_SellinIsZero_Quality_ShouldDecreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInOne_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(18, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").Quality);
        }

        [Fact]
        public void Elixir_SellinIsZero_ShouldBecomeNegative()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInZero_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(-1, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").SellIn);
        }

        [Fact]
        public void Elixir_SellinIsNegative_Quality_ShouldDecreaseByTwo()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInZero_Quality_ShouldDecreaseByTwo_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(18, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").Quality);
        }

        [Fact]
        public void Elixir_SellinGreaterThanZero_Quality_ShouldDecreaseByOne()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInGreaterThanZero_Quality_ShouldDecreaseByOne_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(1, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").SellIn);
            Assert.Equal(19, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").Quality);
        }

        [Fact]
        public void Elixir_SellInGreaterThanZero_QualityIsZero_ShouldBeZero()
        {
            var _inventoryUpdator = TestDataProvider.Elixir_SellInGreaterThanZero_QualityIsZero_Data();

            _inventoryUpdator.UpdateInventory();
            Assert.Equal(1, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").SellIn);
            Assert.Equal(0, _inventoryUpdator.Items.First(x => x.Name == "Elixir of the Mongoose").Quality);
        }
    }
}