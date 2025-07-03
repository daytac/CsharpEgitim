using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for dongusu
            //for(int i=0; i<5 ;i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region while dongusu
            int i = 1;
            while(i<10)
            {
                if(i%3==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            #endregion


            Console.Read();
        }
    }
}
