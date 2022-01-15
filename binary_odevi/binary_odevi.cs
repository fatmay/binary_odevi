using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_odevi
{
    class binarySinifi
    {
        public int fonk(int s1)
        {
            int kalan;
         
            string enson = "";
           
            while (s1 != 0)
            {
                kalan = s1 % 2;
                s1 = s1 / 2;

                enson= kalan.ToString() + enson;//stringe çeviriyoruz çünkü sayilari toplamasini istemiyoruz
                //Console.WriteLine("2'lik Sistem: {0}", kalan);
                Console.WriteLine("2'lik Sistemde Karşılığı : {0}", enson);
              
            }
            return enson;//burada int türünden bir değeri stringe çevirmemize karşı halen aldığımız bir hata sebebiyle kod düzgün çalışmıyor

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            binarySinifi n = new binarySinifi();
            Console.Write("sayiyi Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            fonk(sayi1);
            Console.ReadKey();
        }


    }
}


