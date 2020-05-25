using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Generics_Lab
{
    public class Box<T>
    {
        private int count;
        public List<T> list = new List<T>();
        public int Count
        {
            get;
        }
        public void Add(T element)
        {

            list.Add(element);
           
        }
        public T Remove()
        {
            T value = list[list.Count-1];
            list.RemoveAt(list.Count - 1);
            return value;

        }
    }
}
