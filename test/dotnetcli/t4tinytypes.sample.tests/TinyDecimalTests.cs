using Xunit;

namespace Tests
{
    public class TinyDecimalTests
    {
        [Fact]
        public void TinyDecimalExists() 
        {
            var TinyDecimal = new t4tinytypes.sample.TinyDecimal();
            Assert.NotNull(TinyDecimal);
        }

        [Fact]
        public void TinyDecimalToStringMatches()
        {
            var TinyDecimal = new t4tinytypes.sample.TinyDecimal(1.234m);
            Assert.Equal(1.234m.ToString(), TinyDecimal.ToString());
        }

        
        [Fact]
        public void TinyDecimalEqualityEmptyMatches() 
        {
            var tinyDecimal1 = new t4tinytypes.sample.TinyDecimal();
            var tinyDecimal2 = new t4tinytypes.sample.TinyDecimal();
            
            Assert.Equal(tinyDecimal1, tinyDecimal2); 
        }
        
        [Fact]
        public void TinyDecimalEqualityHelloMatches() 
        {
            var tinyDecimal1 = new t4tinytypes.sample.TinyDecimal(43.21m);
            var tinyDecimal2 = new t4tinytypes.sample.TinyDecimal(43.21m);
            
            Assert.Equal(tinyDecimal1, tinyDecimal2);
            Assert.True(tinyDecimal1.Equals(tinyDecimal2)); 
            Assert.True(tinyDecimal1.Equals((object)tinyDecimal2)); 
            Assert.True(tinyDecimal2.Equals(tinyDecimal1)); 
            Assert.True(tinyDecimal2.Equals((object)tinyDecimal1)); 
        }

        [Fact]
        public void TinyDecimalEqualityDoesNotMatch() 
        {
            var tinyDecimal1 = new t4tinytypes.sample.TinyDecimal(1.1m);
            var tinyDecimal2 = new t4tinytypes.sample.TinyDecimal(4.5m);
            
            Assert.NotEqual(tinyDecimal1, tinyDecimal2);
            Assert.False(tinyDecimal1.Equals(tinyDecimal2)); 
            Assert.False(tinyDecimal1.Equals((object)tinyDecimal2)); 
            Assert.False(tinyDecimal2.Equals(tinyDecimal1)); 
            Assert.False(tinyDecimal2.Equals((object)tinyDecimal1));
        }
    }
}