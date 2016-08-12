using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TinyDecimalExists() 
        {
            var currency = new t4tinytypes.sample.TinyDecimal();
        }
        [Fact]
        public void TinyInt() 
        {
            var dist1 = new t4tinytypes.sample.TinyInt();
        }
        [Fact]
        public void TinyDouble() 
        {
            var dist2 = new t4tinytypes.sample.TinyDouble();
        }
    }
}
