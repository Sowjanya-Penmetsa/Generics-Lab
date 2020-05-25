using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Array_Creator
{
    public class ArrayCreator<T>
    {
        public static T[] Create<T>(int length, T item)
        {
           
            T[] myArray = new T[length];
            
            for (int i= 0;i<length;i++)
            {
                myArray[i] = item;
                Console.WriteLine("the element"+" "+ i+" " +"in the array is:"  + myArray[i]);
                
            }
            return myArray;
        }
    }
}
