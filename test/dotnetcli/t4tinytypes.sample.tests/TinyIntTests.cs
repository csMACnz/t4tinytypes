using Xunit;

namespace Tests
{
    public class TinyIntTests
    {
        [Fact]
        public void TinyIntExists() 
        {
            var tinyInt = new t4tinytypes.sample.TinyInt();
            Assert.NotNull(tinyInt);
        }

        [Fact]
        public void TinyIntToStringMatches()
        {
            var tinyInt = new t4tinytypes.sample.TinyInt(5);
            Assert.Equal(5.ToString(), tinyInt.ToString());
        }

        
        [Fact]
        public void TinyIntEqualityEmptyMatches() 
        {
            var tinyInt1 = new t4tinytypes.sample.TinyInt();
            var tinyInt2 = new t4tinytypes.sample.TinyInt();
            
            Assert.Equal(tinyInt1, tinyInt2); 
        }
        
        [Fact]
        public void TinyIntEqualityHelloMatches() 
        {
            var tinyInt1 = new t4tinytypes.sample.TinyInt(42);
            var tinyInt2 = new t4tinytypes.sample.TinyInt(42);
            
            Assert.Equal(tinyInt1, tinyInt2);
            Assert.True(tinyInt1.Equals(tinyInt2)); 
            Assert.True(tinyInt1.Equals((object)tinyInt2)); 
            Assert.True(tinyInt2.Equals(tinyInt1)); 
            Assert.True(tinyInt2.Equals((object)tinyInt1)); 
        }

        [Fact]
        public void TinyIntEqualityDoesNotMatch() 
        {
            var tinyInt1 = new t4tinytypes.sample.TinyInt(7);
            var tinyInt2 = new t4tinytypes.sample.TinyInt(9);
            
            Assert.NotEqual(tinyInt1, tinyInt2);
            Assert.False(tinyInt1.Equals(tinyInt2)); 
            Assert.False(tinyInt1.Equals((object)tinyInt2)); 
            Assert.False(tinyInt2.Equals(tinyInt1)); 
            Assert.False(tinyInt2.Equals((object)tinyInt1));
        }
    }
}