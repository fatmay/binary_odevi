using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_odevi
{
    class Program
    {

        static void Main(string[] args)
        {
            int  kalan;
            string yazikalan = "";
            Console.Write("Sayıyı Giriniz..:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            while (sayi1 != 0)
            {
                kalan = sayi1 % 2;
                sayi1 = sayi1 / 2;

                yazikalan = kalan.ToString() + yazikalan;
                //Console.WriteLine("2'lik Sistem: {0}", kalan);
            }
            Console.WriteLine("2'lik Sistemde Karşılığı : {0}", yazikalan);

            Console.ReadKey();
        }


    }
}


