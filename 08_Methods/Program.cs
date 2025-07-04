using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar
            //geriye değer döndürmeyen metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Doğa");
            //    Console.WriteLine("Enis");
            //}

            //CustomerList();
            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string Customer)
            //{
            //    Console.WriteLine(Customer);    
            //}
            //WriteMethod("aaa");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int a , int b, int c)
            //{
            //    int result = a + b + c;
            //    Console.WriteLine(result);  
            //}
            //Sum(2, 155, 3);

            #endregion

            #region geriye değer döndüren metotler

            //string StudentName()
            //{
            //    string name = "doğa";
            //    string Surname = "aytac";
            //    return name+ " " + Surname; 
            //}
            //Console.WriteLine(StudentName());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "-Ülke:" + countryName +" -Başkent:"+capital +" -Bayrak:" + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adi: ");
            //x= Console.ReadLine();
            //Console.Write("Başkent: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int x, int y)
            //{
            //    int sonuc = x + y;
            //    return sonuc;
            //}
            //Console.WriteLine(Sum(41,27));

            #endregion

            #region örnek
            string ExemResult(string student, int e1,int e2, int e3)
            {
                int result = e1 + e2 + e3 / 3;
                if (result > 50)
                    return "geçti";
                else return "kaldi";
            }

            Console.WriteLine(ExemResult("doa", 60, 70, 80));
            #endregion

            Console.Read();
        }
    }
}
