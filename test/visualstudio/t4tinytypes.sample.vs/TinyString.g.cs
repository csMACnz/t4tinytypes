using System;
using System.Diagnostics;

namespace t4tinytypes.sample.vs
{
    [DebuggerDisplay("TinyString {_value}")]
    public struct TinyString: IEquatable<TinyString>
    {
        private readonly string _value;

        public TinyString(string value)
        {
            _value = value;
        }
        
        public bool Equals(TinyString other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyString)
            {
                return Equals((TinyString)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }    

        public override string ToString()
        {
            if(_value == null) return null;
            return _value.ToString();
        }
    }
}