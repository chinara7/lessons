using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {

            // OLA BILSIN KI MEN BU TAPSIRIGI SEHV BASA DUSMUSEM ANCAQ ANLADIGIM QEDER  2 FORMADA YAZMAGA CALISDIM . 
                       
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region First
            Console.WriteLine("10 şəhər adı daxil edin");
            Console.Write("1.");
            Console.ReadLine();
            Console.Write("2.");
            Console.ReadLine();
            Console.Write("3.");
            Console.ReadLine();
            Console.Write("4.");
            Console.ReadLine();
            Console.Write("5.");
            Console.Read();
            Console.Write("6.");
            Console.Read();
            Console.Write("7.");
            Console.Read();
            Console.Write("8.");
            Console.Read();
            Console.Write("9.");
            Console.Read();
            Console.Write("10.");
            Console.Read();
            #endregion

            #region Second
            Console.WriteLine("10 şəhər adı daxil edin");
            for (int i = 1; i < 11; i++)
            {
                var city = Console.ReadLine();
                Console.Write(i + city + ",");
            }
            #endregion

            Console.Read();
        }
    }
}
