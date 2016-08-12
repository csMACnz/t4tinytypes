using Xunit;

namespace Tests
{
    public class TinyComparableIntTests
    {
        [Fact]
        public void TinyComparableIntExists() 
        {
            var tinyComparableInt = new t4tinytypes.sample.TinyComparableInt();
            Assert.NotNull(tinyComparableInt);
        }

        [Fact]
        public void TinyComparableIntToStringMatches()
        {
            var tinyComparableInt = new t4tinytypes.sample.TinyComparableInt(5);
            Assert.Equal(5.ToString(), tinyComparableInt.ToString());
        }

        
        [Fact]
        public void TinyComparableIntEqualityEmptyMatches() 
        {
            var tinyComparableInt1 = new t4tinytypes.sample.TinyComparableInt();
            var tinyComparableInt2 = new t4tinytypes.sample.TinyComparableInt();
            
            Assert.Equal(tinyComparableInt1, tinyComparableInt2); 
        }
        
        [Fact]
        public void TinyComparableIntEqualityHelloMatches() 
        {
            var tinyComparableInt1 = new t4tinytypes.sample.TinyComparableInt(42);
            var tinyComparableInt2 = new t4tinytypes.sample.TinyComparableInt(42);
            
            Assert.Equal(tinyComparableInt1, tinyComparableInt2);
            Assert.True(tinyComparableInt1.Equals(tinyComparableInt2)); 
            Assert.True(tinyComparableInt1.Equals((object)tinyComparableInt2)); 
            Assert.True(tinyComparableInt2.Equals(tinyComparableInt1)); 
            Assert.True(tinyComparableInt2.Equals((object)tinyComparableInt1)); 
        }

        [Fact]
        public void TinyComparableIntEqualityDoesNotMatch() 
        {
            var tinyComparableInt1 = new t4tinytypes.sample.TinyComparableInt(7);
            var tinyComparableInt2 = new t4tinytypes.sample.TinyComparableInt(9);
            
            Assert.NotEqual(tinyComparableInt1, tinyComparableInt2);
            Assert.False(tinyComparableInt1.Equals(tinyComparableInt2)); 
            Assert.False(tinyComparableInt1.Equals((object)tinyComparableInt2)); 
            Assert.False(tinyComparableInt2.Equals(tinyComparableInt1)); 
            Assert.False(tinyComparableInt2.Equals((object)tinyComparableInt1));
        }
    }
}