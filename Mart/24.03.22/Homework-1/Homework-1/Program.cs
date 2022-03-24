using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var firstName = "Adınız nədir?";
            var lastName = "Soyadınız nədir?";
            var city = "Hansı şəhərdə yaşayırsınız?";

            Console.WriteLine("Zəhmət olmasa elementləri daxil edərkən ingilis dilli əlifbadan istifadə edin.");
            Console.WriteLine(firstName);
            var name = Console.ReadLine();

            Console.WriteLine(lastName);
            var surname = Console.ReadLine();

            Console.WriteLine(city);
            Console.ReadLine();

            Console.WriteLine(name+" "+ surname+ " "+ "sorğuda iştirak etdiyiniz üçün təşəkkür edirəm :)");
            Console.ReadLine();

        }
    }
}
