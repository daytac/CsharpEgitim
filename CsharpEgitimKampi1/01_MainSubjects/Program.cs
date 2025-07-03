using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hello world
            //Console.WriteLine("hello world");
            //Console.Write("hello");
            #endregion

            #region string
            //string customerName;
            //string customerSurname, customerEmail;
            //customerName = "Doğa";
            //customerSurname = "Aytaç";
            //customerEmail = "erferfeggegrergrtg";
            //Console.WriteLine(customerName + " "+customerSurname);
            //Console.WriteLine(customerEmail);
            #endregion

            #region int
            int hamburger,pizza;
            int hesap;
            hamburger = 100;
            pizza = 200;
            hesap = hamburger + pizza;
            Console.WriteLine("Hamburger: "+ hamburger);
            Console.WriteLine("Pizza: " + pizza);
            Console.WriteLine("Hesap: " + hesap);
            #endregion
            Console.Read();
        }
    }
}
