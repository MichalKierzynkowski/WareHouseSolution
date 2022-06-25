using FluentAssertions;
using FormsLogic.ProductForm.Logic.Entities;
using FormsLogic.ProductForm.Validation.FilteringValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace FunctionalityTests.ProductFormTests.FilteringValidationTests
{
    public class InputFilterByAllValidationTests
    {
        private InputFilterByAllValidation _validator;
        public InputFilterByAllValidationTests()
        {
            _validator = new InputFilterByAllValidation();
        }
        [Fact]
        public void ShouldHaveErorInputIsNull()
        {

            var model = new FilteringOption("");
            var result = _validator.Validate(model);
            result.IsValid.Should().BeFalse();

        }
        [Theory]
        [InlineData("1t")]
        [InlineData("23s")]
        [InlineData("Koszulka2")]
        [InlineData("Koszulka3")]

        public void ShouldHaveErorWhenInputHaveCombinedDigitsAndLetters(string value)
        {
            var model = new FilteringOption(value);
            var result = _validator.Validate(model);
            result.IsValid.Should().BeFalse();
        }
        [Theory]
        [InlineData("Koszulka")]
        [InlineData("23")]
        [InlineData("Koszulkaaa")]
        [InlineData("123")]
        public void ShouldNotHaveErorWhenInputDontHaveCombinedDigitsAndLetters(string value)
        {
            var model = new FilteringOption(value);
            var result = _validator.Validate(model);
            result.IsValid.Should().BeTrue();
        }
    }
}
