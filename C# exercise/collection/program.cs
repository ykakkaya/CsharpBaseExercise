using System;
using System.Collections.Generic;


namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayi= new List<int>();
            sayi.Add(1);
            sayi.Add(3);
            sayi.Add(5);
            sayi.Add(112);
            sayi.Add(34);
            List<string> renk= new List<string>();
            renk.Add("sarı");
            renk.Add("kımızı");
            renk.Add("mavi");
            renk.Add("yeşil");
            Console.WriteLine(renk.Count);
            sayi.ForEach(s=>Console.WriteLine(s));
            sayi.Remove(4);
            renk.Remove("mavi");
            renk.RemoveAt(2);// indisle çıkarır
            renk.ForEach(r=>Console.WriteLine(r));
            Console.WriteLine(sayi.Contains(10));
            string []hayvanlar={"Kedi","köpek","kuş"};
            List<string>hayvan=new List<string>(hayvanlar);
            Console.WriteLine(hayvan.Count);


        }
    }
}
