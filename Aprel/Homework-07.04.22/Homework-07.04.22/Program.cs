using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07._04._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Homework-1
            {
                Console.WriteLine("Birinci ədədi daxil edin:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci ədədi daxil edin:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int num3 = num1;
                num1 = num2;
                num2 = num3;

                Console.WriteLine("Nəticə dəyişdirildi: " + "num1= " + num1 + " " + "num2= " + num2);
                Console.ReadLine();
            }
            #endregion

            #region Homework-2
            {
                Console.WriteLine("Birinci ədədi daxil edin:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci ədədi daxil edin:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci ədədi daxil edin:");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int add = num1 + num2 + num3;
                Console.WriteLine("Cəm: " + num1 + " + " + num2 + " + " + num3 + " = " + add);

                int sub = num1 - num2 - num3;
                Console.WriteLine("Fərq: " + num1 + " - " + num2 + " - " + num3 + " = " + sub);

                int mult = num1 * num2 * num3;
                Console.WriteLine("Hasil: " + num1 + " * " + num2 + " * " + num3 + " = " + mult);

                decimal div = (decimal)num1 / (decimal)num2 / (decimal)num3;
                Console.WriteLine("Nisbət: " + num1 + " / " + num2 + " / " + num3 + " = " + div);

                Console.ReadLine();
            }
            #endregion

            #region Homework-3
            {
                Console.WriteLine("10 ədəd daxil edin:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());
                int num4 = Convert.ToInt32(Console.ReadLine());
                int num5 = Convert.ToInt32(Console.ReadLine());
                int num6 = Convert.ToInt32(Console.ReadLine());
                int num7 = Convert.ToInt32(Console.ReadLine());
                int num8 = Convert.ToInt32(Console.ReadLine());
                int num9 = Convert.ToInt32(Console.ReadLine());
                int num10 = Convert.ToInt32(Console.ReadLine());

                int add = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
                add++;
                Console.WriteLine("Cəm: " + add);

                int sub = num1 - num2 - num3 - num4 - num5 - num6 - num7 - num8 - num9 - num10;
                sub--;
                Console.WriteLine("Fərq: " + sub);

                decimal mult = num1 * num2 * num3 * num4 * num5 * num6 * num7 * num8 * num9 * num10;
                mult *= 20;
                Console.WriteLine("Hasil: " + mult);

                decimal div = (decimal)num1 / (decimal)num2 / (decimal)num3 / (decimal)num4 / (decimal)num5 / (decimal)num6 / (decimal)num7 / (decimal)num8 / (decimal)num9 / (decimal)num10;
                div /= 20;
                Console.WriteLine("Qismət: " + div);
                Console.ReadLine();
            }
            #endregion
        }
    }
}
