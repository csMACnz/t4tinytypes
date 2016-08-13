using System;
using System.Diagnostics;

namespace t4tinytypes.sample.core
{
    [DebuggerDisplay("TinyComparableInt {_value}")]
    public struct TinyComparableInt: IEquatable<TinyComparableInt>, IComparable<TinyComparableInt>
    {
        private readonly int _value;

        public TinyComparableInt(int value)
        {
            _value = value;
        }
        
        public bool Equals(TinyComparableInt other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is TinyComparableInt)
            {
                return Equals((TinyComparableInt)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }      
        public int CompareTo(TinyComparableInt other)
        {
            return _value.CompareTo(other._value);
        }

        public static bool operator ==(TinyComparableInt first, TinyComparableInt second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(TinyComparableInt first, TinyComparableInt second)
        {
            return !(first == second);
        }

        public static bool operator <(TinyComparableInt first, TinyComparableInt second)
        {
            return first.CompareTo(second) < 0;
        }

        public static bool operator <=(TinyComparableInt first, TinyComparableInt second)
        {
            return first.CompareTo(second) <= 0;
        }

        public static bool operator >(TinyComparableInt first, TinyComparableInt second)
        {
            return first.CompareTo(second) > 0;
        }

        public static bool operator >=(TinyComparableInt first, TinyComparableInt second)
        {
            return first.CompareTo(second) >= 0;
        }

    

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}