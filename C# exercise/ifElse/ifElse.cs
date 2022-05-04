using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;
            if (time>=5 && time<12 ){
                Console.WriteLine("günaydın");
            }else if(time>=12 && time<18){
                Console.WriteLine("iyi günler");
            }else if(time>=18 && time<5){
                Console.WriteLine("iyi geceler");
            }
        }
    }
}
