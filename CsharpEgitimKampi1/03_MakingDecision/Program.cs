using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else yapisi basit
            //Console.Write("şifre gir:");
            //string sifre=Console.ReadLine();
            //if (sifre == "abc") 
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}
            #endregion

            #region not gecti kaldi hesabi
            //int vize, final;

            //Console.Write("Vize notu: ");
            //vize = int.Parse(Console.ReadLine());
            //Console.Write("Final notu: ");
            //final = int.Parse(Console.ReadLine());

            //double durum = (vize + final)/2 ;

            //if (durum < 40 & durum >= 0)
            //    Console.Write("kötü ");
            //else if (durum >= 40 & durum < 75)
            //    Console.Write("iyi ");

            //else if (durum >= 75)
            //    Console.Write("mükemmel ");

            //Console.Write(durum);
            #endregion

            #region mod alma ornek
            //int num;
            //Console.Write("sayi gir: ");
            //num=int.Parse(Console.ReadLine());  
            //if (num % 2 ==0) 
            //{
            //    Console.WriteLine("çift sayi");
            //}
            //else
            //{
            //    Console.WriteLine("tek sayi");
            //}
            #endregion

            #region switch case
            Console.Write("ay girişi: ");
            int ay=int.Parse(Console.ReadLine());
            switch (ay) 
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10:Console.Write("Ekim"); break;
                case 11:Console.Write("Kasım"); break;
                case 12:Console.Write("Aralık"); break;
                default: Console.Write("Hatalı veri"); break;
                
            }

            #endregion

            Console.Read();
        }
    }
}
