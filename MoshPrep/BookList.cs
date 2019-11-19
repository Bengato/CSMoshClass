using System;
using System.Collections.Generic;
using System.Text;

namespace MoshPrep
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class GenericDictionary<Tkey, TValue>
    {
        public void Add(Tkey key,TValue value)
        {

        }
    }
}
