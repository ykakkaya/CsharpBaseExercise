using System;

namespace arrayMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num ={23,12,86,72,3,11,17};
            Array.Sort(num);
            foreach(int i in num){
                Console.WriteLine(i);   
            }
            Console.WriteLine("=================");
            Array.Clear(num,3,2);
            //başlanan index numarasından sonra istenilen kadar elemana 0 atar
            foreach(int i in num){
                Console.WriteLine(i);   
            }
            Console.WriteLine("=================");
            Array.Reverse(num);
            foreach(int i in num){
                Console.WriteLine(i);   
            }
            Console.WriteLine("=================");
            Console.WriteLine(Array.IndexOf(num,11));
            Console.WriteLine("=================");
            Array.Resize<int>(ref num,9);

        }
    }
}
