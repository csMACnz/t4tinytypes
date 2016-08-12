using System;
using Xunit;

namespace Tests
{
    public class TinyStringTests
    {
        [Fact]
        public void TinyStringExists() 
        {
            var tinyString = new t4tinytypes.sample.TinyString();
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
        }

        [Fact]
        public void TinyStringEqualityDoesNotMatch() 
        {
            var tinyString1 = new t4tinytypes.sample.TinyString("Hello");
            var tinyString2 = new t4tinytypes.sample.TinyString("World");
            
            Assert.NotEqual(tinyString1, tinyString2); 
        }
    }
}
