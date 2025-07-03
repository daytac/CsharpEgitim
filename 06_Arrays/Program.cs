using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi ornekleri
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "siyah";
            //colors[2] = "mavi";
            //colors[3] = "mor";

            //Console.WriteLine(colors[0]);

            //int[] numb = new int[10];
            //numb[0] = 1;
            //numb[1] = 2;
            //numb[2] = 3;
            //Console.WriteLine(numb[0]);
            //Console.WriteLine(numb[5]);

            //string[] cities = { "a", "b"};
            //Console.WriteLine(cities[0]);

            #endregion

            #region tum elemanlari listeleme
            //string[] colors = { "mor","mavi","kırmızı"};
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] num = { 10, 20, 30 };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i]%3==0) 
            //    {
            //        Console.WriteLine(num[i]);
            //    }
            //}

            #endregion

            #region dizi metotlari

            //string[] customers = { "enis", "doa", "zehra", "sude"};
            //int index=Array.IndexOf(customers, "enis");
            //Console.WriteLine(index);   

            //int[] num = { 21, 2, 33, 100, 58 };
            //Console.WriteLine("en büyük: "+ num.Max()+ " en kucuk: " + num.Min());

            #endregion

            #region kullanicidan deger alma

            string[] cities = new string[3];
            for (int i = 0; i < cities.Length; i++) 
            {
                Console.Write($"lütfen {i+1}. şehri gir: ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine("-----");
            for (int i = 0;i < cities.Length; i++) 
            {
                Console.WriteLine(cities[i]);
            }
            #endregion

            Console.Read();
        }
    }
}
