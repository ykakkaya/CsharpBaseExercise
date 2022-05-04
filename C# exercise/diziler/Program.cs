using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizimizin boyutunu giriniz :" );
            int boyut =int.Parse(Console.ReadLine());
            int []arr=new int[boyut];
            int ort=0;
            int toplam=0;
            Console.WriteLine("dizimizin elemanlarını giriniz");
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine("dizinin "+ (i+1)+ " inci elemanını giriniz");
                arr[i]= int.Parse(Console.ReadLine());
                
                toplam =toplam+ arr[i];
                ort= (toplam/ boyut);
                Console.WriteLine("toplam: "+toplam);

            }
            
            Console.WriteLine("dizinin ortalaması : " + ort);
           

        
        }
    }
}
