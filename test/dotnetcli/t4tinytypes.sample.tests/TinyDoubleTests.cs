using Xunit;

namespace Tests
{
    public class TinyDoubleTests
    {
        [Fact]
        public void TinyDoubleExists() 
        {
            var tinyDouble = new t4tinytypes.sample.TinyDouble();
            Assert.NotNull(tinyDouble);
        }

        [Fact]
        public void TinyDoubleToStringMatches()
        {
            var tinyDouble = new t4tinytypes.sample.TinyDouble(5.0);
            Assert.Equal(5.0.ToString(), tinyDouble.ToString());
        }

        
        [Fact]
        public void TinyDoubleEqualityEmptyMatches() 
        {
            var tinyDouble1 = new t4tinytypes.sample.TinyDouble();
            var tinyDouble2 = new t4tinytypes.sample.TinyDouble();
            
            Assert.Equal(tinyDouble1, tinyDouble2); 
        }
        
        [Fact]
        public void TinyDoubleEqualityHelloMatches() 
        {
            var tinyDouble1 = new t4tinytypes.sample.TinyDouble(42.3);
            var tinyDouble2 = new t4tinytypes.sample.TinyDouble(42.3);
            
            Assert.Equal(tinyDouble1, tinyDouble2);
            Assert.True(tinyDouble1.Equals(tinyDouble2)); 
            Assert.True(tinyDouble1.Equals((object)tinyDouble2)); 
            Assert.True(tinyDouble2.Equals(tinyDouble1)); 
            Assert.True(tinyDouble2.Equals((object)tinyDouble1)); 
        }

        [Fact]
        public void TinyDoubleEqualityDoesNotMatch() 
        {
            var tinyDouble1 = new t4tinytypes.sample.TinyDouble(7.8);
            var tinyDouble2 = new t4tinytypes.sample.TinyDouble(9.8);
            
            Assert.NotEqual(tinyDouble1, tinyDouble2);
            Assert.False(tinyDouble1.Equals(tinyDouble2)); 
            Assert.False(tinyDouble1.Equals((object)tinyDouble2)); 
            Assert.False(tinyDouble2.Equals(tinyDouble1)); 
            Assert.False(tinyDouble2.Equals((object)tinyDouble1));
        }
    }
}