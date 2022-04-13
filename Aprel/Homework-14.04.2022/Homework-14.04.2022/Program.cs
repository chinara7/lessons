using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Homework-1
            /* İstifadəçi mənfi dəyər daxil edənə qədər, daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın. */

            //Console.WriteLine("eded daxil edin");
            //int add = 0;
            //int number = 0;

            /* DO WHILE ILE */

            //do
            //{
            //    add += number;
            //    number = Convert.ToInt32(Console.ReadLine());

            //} while (number >= 0);
            //Console.WriteLine("netice: " + add);
            //Console.ReadLine();

            /* WHILE ILE */

            //number = Convert.ToInt32(Console.ReadLine());
            //while (number >= 0)
            //{
            //    add += number;
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("netice: " + add);

            //Console.ReadLine();
            #endregion


            #region multiplication table
            /*
             Homework 2: Belə bir vurma cədvəli çıxardın ekrana. İp ucu verim, Console.Write("1*1=2\t"); yazacaqsız.Orda \t sizə boşluqları
             təmin edəcək.Logic hissəsini isə özünüz fikirləşin.
                1 * 1 = 1   1 * 2 = 2   1 * 3 = 3   1 * 4 = 4   1 * 5 = 5   1 * 6 = 6   1 * 7 = 7   1 * 8 = 8   1 * 9 = 9
                2 * 1 = 2   2 * 2 = 4   2 * 3 = 6   2 * 4 = 8   2 * 5 = 10  2 * 6 = 12  2 * 7 = 14  2 * 8 = 16  2 * 9 = 18
                3 * 1 = 3   3 * 2 = 6   3 * 3 = 9   3 * 4 = 12  3 * 5 = 15  3 * 6 = 18  3 * 7 = 21  3 * 8 = 24  3 * 9 = 27
                4 * 1 = 4   4 * 2 = 8   4 * 3 = 12  4 * 4 = 16  4 * 5 = 20  4 * 6 = 24  4 * 7 = 28  4 * 8 = 32  4 * 9 = 36
                5 * 1 = 5   5 * 2 = 10  5 * 3 = 15  5 * 4 = 20  5 * 5 = 25  5 * 6 = 30  5 * 7 = 35  5 * 8 = 40  5 * 9 = 45
                6 * 1 = 6   6 * 2 = 12  6 * 3 = 18  6 * 4 = 24  6 * 5 = 30  6 * 6 = 36  6 * 7 = 42  6 * 8 = 48  6 * 9 = 54
                7 * 1 = 7   7 * 2 = 14  7 * 3 = 21  7 * 4 = 28  7 * 5 = 35  7 * 6 = 42  7 * 7 = 49  7 * 8 = 56  7 * 9 = 63
                8 * 1 = 8   8 * 2 = 16  8 * 3 = 24  8 * 4 = 32  8 * 5 = 40  8 * 6 = 48  8 * 7 = 56  8 * 8 = 64  8 * 9 = 72
                9 * 1 = 9   9 * 2 = 18  9 * 3 = 27  9 * 4 = 36  9 * 5 = 45  9 * 6 = 54  9 * 7 = 63  9 * 8 = 72  9 * 9 = 81
                */

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int c = i * j;
            //        Console.Write(i + "*" + j + "=" + c + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();
            #endregion


            #region Homework-3
            /*
             Homework 3: 
             App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
             alınmalıdır. Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi 
             tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
             Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir. Sadəcə 2. 3. 4. deyə artır cəhd sayı. İstifadəçi düzgün rəqəmi
             tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.
             */

            //Console.WriteLine("Təxmin oyunu ucun ən yuksek dəyəri daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Random randomNumber = new Random();
            //int generate = randomNumber.Next(1, number);

            //int testNumber = 1;
            //Console.WriteLine(testNumber + ". Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: ");
            //int userNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------------");
            //while (generate != userNumber)
            //{
            //    testNumber++;
            //    Console.WriteLine(testNumber + ". Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: ");
            //    userNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("-----------------------------------------------------");
            //}
            //Console.WriteLine(testNumber + ". Cəhdinizdə düzgün rəqəmi tapdınız!");
            //Console.ReadLine();
            #endregion

        }
    }
}
