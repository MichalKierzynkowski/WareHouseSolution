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
            var sev = "test";


            //act
            var validationObj = new IsNullIAddingItemValidation(fir, sec, thi, four, fiv, six, sev);
            var listToTest = validationObj.list;


            //assert

            Assert.False(validationObj.isNullValidation(listToTest));
        }


      
        [Fact]
        public void BarNumberValidation()
        {
            //arrange 
            string barNumber = "123.";

            //act
            var validatioObj = new RulesValidationAddingItem();
            //assert
            
            var isCorrect = validatioObj.ShowHouseBarNumberValidation(barNumber);

            Assert.False(isCorrect);

        }
    }
}