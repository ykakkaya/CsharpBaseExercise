using System;

namespace tip_donusum
{
    class Program
    {
        static void Main(string[] args)
        {
            short a=5;
            sbyte b=3;
            int c= a+b;
            Console.WriteLine("c değeri : "+ c);
            String d="ali ata bak";
            char e= 'p';
            object f= c+d+e;
            Console.WriteLine("son hali : "+ f);
            Console.WriteLine("****expilicit conversion****");
            
            int x=5;
            String st= x.ToString();
            Console.WriteLine("string e cast olmuş hali: "+st);

            String s="544";
            int xx= Convert.ToInt32(s);
            String s1="536";
            int xxx= Convert.ToInt32(s1);
            Console.WriteLine(s+s1);
            Console.WriteLine("int cast işlemi sonrası: "+(xx+xxx));

            Console.WriteLine("----------------");
            Console.WriteLine(0.1+0.2);

        }
    }
}
