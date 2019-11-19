using System;
using System.Collections.Generic;
using System.Text;

namespace MoshPrep
{
    public class Nullable<T> where T: struct
    {
        private object _value;
        public bool HasValue
        {
            get { return _value != null; }
        }
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }
}
