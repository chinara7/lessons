using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Homework-1
            /*
            Homework 1:
             İki dənə array yaradacaqsız və user'dən tələbənin ad və yaş məlumatlarını alıb bu array'lərdə saxlayacaqsız. Array'ların ölçüsü eyni
             olacaq və onu da user'dən soruşacaqsız. Sonra döngüdə istifadəçidən ad və yaş məlumatlarını ayrı-ayrılıqda soruşub array'lərə
             dolduracaqsız.Sonra başqa bir for döngüsündə tələbənin ad və yaş məlumatlarını index'lə birlikdə ekrana yazdıracaqsız.
            (0.Orkah 27 yaşındadır.)
            */

            //Console.WriteLine("Tələbələrin sayını daxil edin:");
            //byte studentNumber = Convert.ToByte(Console.ReadLine());
            //int[] studentAge = new int[studentNumber];
            //string[] studentName = new string[studentNumber];

            //Console.WriteLine("-------------------------------------------------");
            //for (int i = 0; i < studentNumber; i++)
            //{
            //    Console.WriteLine("{0}. Tələbənin adını daxil edin:", i + 1);
            //    studentName[i] = Console.ReadLine();
            //    Console.WriteLine("{0}. Tələbənin yaşını daxil edin:", i + 1);
            //    studentAge[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("-------------------------------------------------");
            //for (int i = 0; i < studentNumber; i++)
            //{
            //    Console.WriteLine("{0}. {1} {2} yaşındadır.", i + 1, studentName[i], studentAge[i]);
            //}

            //Console.ReadLine();
            #endregion


            #region Homework-2
            /*
            Homework 2:
             Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.Bunun üçün öncə bütün elementlərin toplamını
             tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
             bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
             Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.Bunu həm for döngüsüylə edin həm də foreach.
             */

            //Console.WriteLine("Massivin uzunluğunu daxil edin:");
            //int arrLength = int.Parse(Console.ReadLine());
            //int[] numberArray = new int[arrLength];
            //decimal addNumber = 0;

            //int i = 0;
            //while (i < arrLength) 
            //{
            //    Console.WriteLine("Ədəd daxil edin:");
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //    i++;
            //}
            //Console.Clear();

            //foreach (int item in numberArray)
            //{
            //    Console.Write(item + ", ");
            //    addNumber += item;
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Massivin elementlərinin ədədi ortası --> {0}", addNumber / numberArray.Length);

            //Console.ReadLine();
            #endregion


            #region Homework-3

            /* 
             Homework 3:
             int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın.
             Ancaq bunu edərkən sort və reverse method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.
             */

            //int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            //int minValue = 0;

            //for (int m = 0; m <= numArr.Length - 1; m++) 
            //{
            //    for (int n = m + 1; n < numArr.Length; n++) 
            //    {
            //        if (numArr[m] > numArr[n])
            //        {
            //            minValue = numArr[m];
            //            numArr[m] = numArr[n];
            //            numArr[n] = minValue;
            //        }
            //    }                
            //}

            //foreach (int item in numArr)
            //{
            //    Console.Write(item + ", ");
            //}

            //Console.ReadLine();
            #endregion


            #region Homework-4
            /*
            Homework 4:
             Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
             toplamını ekrana yazdırın. (Max və Min method'larından istifadə etmək olmaz)
             */

            int[] numArray = new int[100];
            Random rand = new Random();
            int minValue = numArray[0];
            int maxValue = numArray[0];
            int add = 0;

            // elementler yaradildi
            for (int i = 0; i < numArray.Length; i++)
            {
                int generate = rand.Next(1, 100000);
                numArray[i] = generate;
            }

            // Ən kiçik və ən böyük ədədin tapılması
            for (int m = 0; m < numArray.Length; m++)
            {
                minValue = numArray[m];
                for (int n = 0; n < numArray.Length; n++)
                {
                    if (numArray[n] < minValue && numArray[n] != minValue)
                    {
                        minValue = numArray[n];
                    }
                    if (numArray[n] > maxValue && numArray[n] != maxValue)
                    {
                        maxValue = numArray[n];
                    }
                }
            }

            // Cəmin hesablanması
            foreach (int item in numArray)
            {
                add += item;
            }

            // Elementlərin ekrana yazılması
            foreach (int item in numArray)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Massivin elementlərinin cəmi - {0}", add);
            Console.WriteLine("Massivin ən kiçik ədədi - {0}", minValue);
            Console.WriteLine("Massivin ən böyük ədədi - {0}", maxValue);
            Console.ReadLine();
            #endregion
        }
    }
}
