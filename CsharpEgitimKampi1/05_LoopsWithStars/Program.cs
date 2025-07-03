using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta yildiz
            //for (int i=0;i<5;i++) 
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region dik ucgen
            //for (int i = 1; i <= 5; i++) 
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region ters dik ucgen
            //for (int i = 5; i >= 1; i--)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region dik ve ters dik ucgen

            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 6; k >= 1; k--)
            //{

            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region piramid
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region ters piramid
            int m= 5;
            for( int i = m;i>=1;i--)
            {
                for(int j=m-i;j>0;j--)
                {
                    Console.Write(" ");
                }

                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write("*");
                } 

                Console.WriteLine();
            }
            #endregion
            Console.Read();
        }
    }
}
