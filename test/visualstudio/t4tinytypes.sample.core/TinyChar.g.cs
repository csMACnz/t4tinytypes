using System;
using System.Diagnostics;

namespace t4tinytypes.sample.core
{
    [DebuggerDisplay("TinyChar {_value}")]
    public struct TinyChar: IEquatable<TinyChar>
    {
        private readonly char _value;

        public TinyChar(char value)
        {
            _value = value;
        }
        
        public bool Equals(TinyChar other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyChar)
            {
                return Equals((TinyChar)obj);
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