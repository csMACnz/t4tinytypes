using System;
using System.Diagnostics;

namespace t4tinytypes.sample.vs
{
    [DebuggerDisplay("TinyInt {_value}")]
    public struct TinyInt: IEquatable<TinyInt>
    {
        private readonly int _value;

        public TinyInt(int value)
        {
            _value = value;
        }
        
        public bool Equals(TinyInt other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyInt)
            {
                return Equals((TinyInt)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }    

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}