using System;

namespace stringler
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "merhaba csharp çalışıyorum";
            string s2="dersimiz csharp";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.CompareTo(s2));
            Console.WriteLine(s.Contains("csharp"));//ilk bulduğu index i döndü
            Console.WriteLine(s2.Insert(0,"hello "));//ekleme yaptı
            Console.WriteLine(s2.Remove(10,3));//indexten sonrasını girilen kadar siler
            Console.WriteLine(s.Replace("csharp","c#"));
            Console.WriteLine(s.Split(' ')[1]);
            
        }
    }
}
