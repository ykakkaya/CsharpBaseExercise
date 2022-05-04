using System;
using System.Collections;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            ciftSayilar();
            tamBolen();
            kelimeTerstenYaz();
            harfSay();
        }

        public static void ciftSayilar(){
            Console.WriteLine("kaç sayı gireceksiniz?");
            var number=Convert.ToInt32(Console.ReadLine());
            ArrayList cift=new ArrayList();

            for(int i=1;i<=number;i++){
                Console.WriteLine("bir sayı giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());               
                if(sayi%2==0){
                    cift.Add(sayi);
                }
            }
            Console.WriteLine("girilen çift sayılar: ");
            foreach (var item in cift)
            {
                
                Console.Write(item+" ");
            }
        }

        public static void tamBolen(){
            Console.WriteLine("bir sayı giriniz");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            int m= Convert.ToInt32(Console.ReadLine());
            ArrayList bolenler=new ArrayList();

            for(int i=1; i<=n; i++){
                Console.WriteLine("bir sayı giriniz");
                int num= Convert.ToInt32(Console.ReadLine());
                if(m%num==0 || m==num){
                    bolenler.Add(num);
                }
            }
            Console.Write(m+"sayısını tam bölenler");
            foreach (var item in bolenler)
            {
                Console.Write(item+" ");
            }
        }

        public static void kelimeTerstenYaz(){
            Console.WriteLine("kaç kelime gireceksiniz");
            int num=Convert.ToInt32(Console.ReadLine());
            String[]kelime=new String[num];
            for(int i=1;i<=num;i++){
                Console.WriteLine(i+"inci kelimeyi giriniz");
                String words= Console.ReadLine();
                kelime[i-1]=words;
            }
        
            for(int i=num ;i>=1;i--){
                Console.Write(kelime[i-1]+" ");
            }

        }
        public static void harfSay(){
            Console.WriteLine("bir cümle giriniz");
            String sentence= Console.ReadLine();
            string[]kelime=sentence.Split(" ");
            Console.WriteLine("girilen kelime sayısı: "+ kelime.Length);
            Console.WriteLine("girilen harf sayısı "+sentence.Length);

        }
    }
}
