using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü

            //string[] cities = { "bursa", "ankara", "hatay", "uşak", "tokat" };
            //foreach (string city in cities) 
            //{ 
            //    Console.WriteLine(city);
            //}


            //int[] number = { 1154, 2872, 545, 68, 265, 9988, 325 };
            //int total = 0;
            //foreach (int i in number)
            //{
            //    total += i;
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("toplam:"+total);


            //List<int> numbers = new List<int>()
            //{ 1,2,3,4,5,6,7,8};
            //foreach (int i in numbers)
            //{ 
            //    Console.WriteLine(i);
            //}

            //string word = "selam";
            //foreach (char c in word) 
            //{ 
            //    Console.WriteLine(c);
            //}

            #endregion

            #region örnek sınav sistemi

            //öğrenci sayısını kullanıcıdan alma
            Console.Write("öğrenci sayisi: ");
            int studentCount=int.Parse(Console.ReadLine());

            //öğrenci isimlerini ve not ortalamalarını saklicak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];   

            for (int i=0; i<studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismi:");
                studentNames[i] = Console.ReadLine();

                double totalExemResult = 0;

                //her öğrenci için 3 sınav girişi
                for(int j=0; j<3; j++) 
                {
                    Console.Write($"{studentNames[i] } nin {j+1}. notu: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExemResult += value;
                }
                studentExamAvg[i] = totalExemResult/3;    
            }

            //sınav ortalamaları
            for(int i=0;i<studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} nin ortalamasi: { studentExamAvg[i]}");
                //ortalama ve geçip kalma durumu
                if (studentExamAvg[i] >50) 
                { 
                    Console.WriteLine($"{studentNames[i]} dersi geçti"); 
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} dersten kaldi");
                }
            }


            #endregion
            Console.Read();
        }
    }
}