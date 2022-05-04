using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            topla(54,18);
            topla(36,14,10);
        }
        public static void topla(int x, int y){
            Console.WriteLine(x+y);
        }
        public static void topla(int x, int y, int z){
            Console.WriteLine(x+y+z);
        }
    }
}
