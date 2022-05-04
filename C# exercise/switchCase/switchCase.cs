using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay= DateTime.Now.Month;
            Console.WriteLine("kaçıncı aydayız: "+ay);
            switch(ay)
            {
                case 12:
                case 1:
                case 2: 
                    Console.WriteLine("kış mevsimindeyiz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındayız");
                    break;
                default: 
                    Console.WriteLine("sonbahar ayınsayız"); 
                    break;       
            }
            
        }
    }
}