using Xunit;

namespace Tests
{
    public class TinyCharTests
    {
        [Fact]
        public void TinyCharExists() 
        {
            var tinyChar = new t4tinytypes.sample.TinyChar();

            Assert.NotNull(tinyChar);
        }

        [Fact]
        public void TinyCharToStringMatches() 
        {
            var tinyChar = new t4tinytypes.sample.TinyChar('g');
            Assert.Equal('g'.ToString(), tinyChar.ToString());
        }

        [Fact]
        public void TinyCharEqualityEmptyMatches() 
        {
            var tinyChar1 = new t4tinytypes.sample.TinyChar();
            var tinyChar2 = new t4tinytypes.sample.TinyChar();
            
            Assert.Equal(tinyChar1, tinyChar2); 
        }
        
        [Fact]
        public void TinyCharEqualityHelloMatches() 
        {
            var tinyChar1 = new t4tinytypes.sample.TinyChar('h');
            var tinyChar2 = new t4tinytypes.sample.TinyChar('h');
            
            Assert.Equal(tinyChar1, tinyChar2);
            Assert.True(tinyChar1.Equals(tinyChar2)); 
            Assert.True(tinyChar1.Equals((object)tinyChar2)); 
            Assert.True(tinyChar2.Equals(tinyChar1)); 
            Assert.True(tinyChar2.Equals((object)tinyChar1)); 
        }

        [Fact]
        public void TinyCharEqualityDoesNotMatch() 
        {
            var tinyChar1 = new t4tinytypes.sample.TinyChar('h');
            var tinyChar2 = new t4tinytypes.sample.TinyChar('w');
            
            Assert.NotEqual(tinyChar1, tinyChar2);
            Assert.False(tinyChar1.Equals(tinyChar2)); 
            Assert.False(tinyChar1.Equals((object)tinyChar2)); 
            Assert.False(tinyChar2.Equals(tinyChar1)); 
            Assert.False(tinyChar2.Equals((object)tinyChar1));
        }
    }
}
