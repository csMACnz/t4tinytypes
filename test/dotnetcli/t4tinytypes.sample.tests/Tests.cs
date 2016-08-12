using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TinyDecimalExists() 
        {
            var tinyDecimal = new t4tinytypes.sample.TinyDecimal();

            Assert.NotNull(tinyDecimal);
        }

        [Fact]
        public void TinyDouble() 
        {
            var tinyDouble = new t4tinytypes.sample.TinyDouble();

            Assert.NotNull(tinyDouble);
        }
    }
}
