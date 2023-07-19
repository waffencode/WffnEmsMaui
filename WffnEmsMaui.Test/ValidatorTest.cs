using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test
{
    public class ValidatorTest
    {
        [Fact]
        public void ShouldReturnTrueOnValidName()
        {
            Assert.True(Validator.IsValidName("Test"));
            Assert.True(Validator.IsValidName("Test-Test"));
        }

        [Fact]
        public void ShouldReturnFalseOnInvalidName()
        {
            Assert.False(Validator.IsValidName("test"));
            Assert.False(Validator.IsValidName("tEsT"));
            Assert.False(Validator.IsValidName("TesT"));
            Assert.False(Validator.IsValidName("TEST"));
            Assert.False(Validator.IsValidName("Test-TeST"));
            Assert.False(Validator.IsValidName("TEst-Test"));
        }

        [Fact]
        public void ShouldReturnTrueOnValidEmail()
        {
            Assert.True(Validator.IsValidEmail("example@example.com"));
        }

        [Fact]
        public void ShouldReturnFalseOnInvalidEmail()
        {
            Assert.False(Validator.IsValidEmail("example.com"));
            Assert.False(Validator.IsValidEmail("example@.com"));
            Assert.False(Validator.IsValidEmail("example.com@mail"));
        }
    }
}
