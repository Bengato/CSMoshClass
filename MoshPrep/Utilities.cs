using System;
using System.Collections.Generic;
using System.Text;

namespace MoshPrep
{
    public class Utilities<T> where T : IComparable, new()
    {
        //where T:IComparable
        //where T : Product
        //where T : struct
        //where T:class
        //where T:new()
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public T Max(T a, T b) 
        {
            return a.CompareTo(b)>0 ? a : b;
        }

    }
}
