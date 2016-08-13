using System;
using System.Diagnostics;

namespace t4tinytypes.sample.core
{
    [DebuggerDisplay("TinyDecimal {_value}")]
    public struct TinyDecimal: IEquatable<TinyDecimal>
    {
        private readonly decimal _value;

        public TinyDecimal(decimal value)
        {
            _value = value;
        }
        
        public bool Equals(TinyDecimal other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyDecimal)
            {
                return Equals((TinyDecimal)obj);
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