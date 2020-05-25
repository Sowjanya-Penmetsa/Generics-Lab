using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Generic_scale
{
    public class Scale<T> where T:IComparable
    {
        private T left;
        private T right;
        public Scale(T left,T right)
        {
            this.left = left;
            this.right = right;
        }
        /*public T Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public T Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }

        }*/

        public T GetHeavier()
        {
            var Big = left.CompareTo(right);
            if (Big>0)
            {
                Console.WriteLine("The biggest value is:");
                return left;
            }

            else if (Big<0)
            {
                Console.WriteLine("The biggest value is:");
                return right;
            }
            
                return default(T);
                
           

           
        }
    }
}
