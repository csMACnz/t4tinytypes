using System;
using System.Diagnostics;

namespace t4tinytypes.sample.vs
{
    [DebuggerDisplay("TinyDouble {_value}")]
    public struct TinyDouble: IEquatable<TinyDouble>
    {
        private readonly double _value;

        public TinyDouble(double value)
        {
            _value = value;
        }
        
        public bool Equals(TinyDouble other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyDouble)
            {
                return Equals((TinyDouble)obj);
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