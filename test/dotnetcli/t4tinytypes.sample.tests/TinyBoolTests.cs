using Xunit;

namespace Tests
{
    public class TinyBoolTests
    {
        [Fact]
        public void TinyBoolExists() 
        {
            var tinyBool = new t4tinytypes.sample.TinyBool();

            Assert.NotNull(tinyBool);
        }

        [Fact]
        public void TinyBoolToStringMatches() 
        {
            var tinyBool = new t4tinytypes.sample.TinyBool(true);
            Assert.Equal(true.ToString(), tinyBool.ToString());
        }

        [Fact]
        public void TinyBoolEqualityEmptyMatches() 
        {
            var tinyBool1 = new t4tinytypes.sample.TinyBool();
            var tinyBool2 = new t4tinytypes.sample.TinyBool();
            
            Assert.Equal(tinyBool1, tinyBool2); 
        }
        
        [Fact]
        public void TinyBoolEqualityHelloMatches() 
        {
            var tinyBool1 = new t4tinytypes.sample.TinyBool(true);
            var tinyBool2 = new t4tinytypes.sample.TinyBool(true);
            
            Assert.Equal(tinyBool1, tinyBool2);
            Assert.True(tinyBool1.Equals(tinyBool2)); 
            Assert.True(tinyBool1.Equals((object)tinyBool2)); 
            Assert.True(tinyBool2.Equals(tinyBool1)); 
            Assert.True(tinyBool2.Equals((object)tinyBool1)); 
        }

        [Fact]
        public void TinyBoolEqualityDoesNotMatch() 
        {
            var tinyBool1 = new t4tinytypes.sample.TinyBool(true);
            var tinyBool2 = new t4tinytypes.sample.TinyBool(false);
            
            Assert.NotEqual(tinyBool1, tinyBool2);
            Assert.False(tinyBool1.Equals(tinyBool2)); 
            Assert.False(tinyBool1.Equals((object)tinyBool2)); 
            Assert.False(tinyBool2.Equals(tinyBool1)); 
            Assert.False(tinyBool2.Equals((object)tinyBool1));
        }
    }
}
