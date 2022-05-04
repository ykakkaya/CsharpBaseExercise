using System;

namespace oparatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           int x=3;
           int y=5;
           x +=2;
           Console.WriteLine("x değeri "+ x);
           y*=5;
           Console.WriteLine("y nin değeri "+y);
           bool isSuccess=true;
           bool isComplate=false;
           if(isComplate==isSuccess){
               Console.WriteLine("perfect!!");
           }else{
               Console.WriteLine("not perfect!! ");
           }
        }
    }
}
