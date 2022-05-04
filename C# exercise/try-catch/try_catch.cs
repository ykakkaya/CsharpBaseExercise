using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int num=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girilen değer: "+num);

            } catch(Exception e)
            {
                Console.WriteLine("hatamız: " + e.Message.ToString());
            } 
            finally
            {
                Console.WriteLine("işleminiz tamamlandı");
            }


            
        }
    }
}
