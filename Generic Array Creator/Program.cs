using System;

namespace Generic_Array_Creator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = ArrayCreator<string>.Create(5, "Peter");
            Console.WriteLine(" ");
            int[] integers = ArrayCreator<int>.Create(10, 33);
        }
           
    }
}

