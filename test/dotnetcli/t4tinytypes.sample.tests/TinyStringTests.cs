using Xunit;

namespace Tests
{
    public class TinyStringTests
    {
        [Fact]
        public void TinyStringExists() 
        {
            var tinyString = new t4tinytypes.sample.TinyString();

            Assert.NotNull(tinyString);
        }

        [Fact]
        public void TinyStringToStringMatches() 
        {
            var tinyString = new t4tinytypes.sample.TinyString("Watsit");
            Assert.Equal("Watsit", tinyString.ToString());
        }

        [Fact]
        public void TinyStringEqualityEmptyMatches() 
        {
            var tinyString1 = new t4tinytypes.sample.TinyString();
            var tinyString2 = new t4tinytypes.sample.TinyString();
            
            Assert.Equal(tinyString1, tinyString2); 
        }
        
        [Fact]
        public void TinyStringEqualityHelloMatches() 
        {
            var tinyString1 = new t4tinytypes.sample.TinyString("Hello");
            var tinyString2 = new t4tinytypes.sample.TinyString("Hello");
            
            Assert.Equal(tinyString1, tinyString2);
            Assert.True(tinyString1.Equals(tinyString2)); 
            Assert.True(tinyString1.Equals((object)tinyString2)); 
            Assert.True(tinyString2.Equals(tinyString1)); 
            Assert.True(tinyString2.Equals((object)tinyString1)); 
        }

        [Fact]
        public void TinyStringEqualityDoesNotMatch() 
        {
            var tinyString1 = new t4tinytypes.sample.TinyString("Hello");
            var tinyString2 = new t4tinytypes.sample.TinyString("World");
            
            Assert.NotEqual(tinyString1, tinyString2);
            Assert.False(tinyString1.Equals(tinyString2)); 
            Assert.False(tinyString1.Equals((object)tinyString2)); 
            Assert.False(tinyString2.Equals(tinyString1)); 
            Assert.False(tinyString2.Equals((object)tinyString1));
        }
    }
}
