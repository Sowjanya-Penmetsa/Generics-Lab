using System;

namespace Generic_scale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>(40,60);
            
            Console.Write(scale.GetHeavier());
            Console.ReadLine();
            
        }
    }
}
