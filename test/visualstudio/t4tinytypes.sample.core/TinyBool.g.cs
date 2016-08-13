using System;
using System.Diagnostics;

namespace t4tinytypes.sample.core
{
    [DebuggerDisplay("TinyBool {_value}")]
    public struct TinyBool: IEquatable<TinyBool>
    {
        private readonly bool _value;

        public TinyBool(bool value)
        {
            _value = value;
        }
        
        public bool Equals(TinyBool other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyBool)
            {
                return Equals((TinyBool)obj);
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