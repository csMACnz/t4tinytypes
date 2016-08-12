using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void CurrencyExists() 
        {
            var currency = new t4tinytypes.sample.Currency();
        }
        [Fact]
        public void Distance1Exists() 
        {
            var dist1 = new t4tinytypes.sample.Distance1();
        }
        [Fact]
        public void Distance2Exists() 
        {
            var dist2 = new t4tinytypes.sample.Distance2();
        }
    }
}
