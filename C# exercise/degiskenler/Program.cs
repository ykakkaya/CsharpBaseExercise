using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger=5;
            String name= "ali";
            Console.WriteLine( name+ " "+ deger+ " yaşındadır");
            String s= "20";
            int s2=20;
            String yenideger= s+ s2.ToString();
            Console.WriteLine( "iki sitrin birleşimi "+yenideger);
            int sondeger= s2+ Convert.ToInt32(s);
            Console.WriteLine("son değerimiz int "+ sondeger);
            String str= DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(str);
            String str1= DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(str1);
            String hour= DateTime.Now.ToString("HH.mm");
            Console.WriteLine("saat"+ hour);

        }
    }
}
