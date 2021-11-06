using ClassesLibrary;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsNullAddingItemValidationTest()
        {
            //arange
            var fir = "test";
            var sec = "test";
            var thi = "test";
            var four = "test";
            var fiv = "test";
            var six = "test";
           


            //act
            var validationObj = new IsNullIAddingItemValidation(fir, sec, thi, four, fiv, six);
            var listToTest = validationObj.list;


            //assert

            Assert.False(validationObj.isNullValidation(listToTest));
        }


        [Fact]
        public void RulesValidationAddingItem()
        {
            //arange
            var ProductInfo = "Test";
            var ProductType = "12";
            var BarNumber = "0123";
            var MethodOfBuying = "1";
          
            var PriceSelling = "35";
            var AmountOfProduct = "12";

            //act
            var validationObj = new RulesValidationAddingItem();
                 

            
            //assert
            Assert.True(validationObj.Validation(ProductInfo, ProductType, BarNumber,
                MethodOfBuying, PriceSelling, AmountOfProduct));
        }
    }
}