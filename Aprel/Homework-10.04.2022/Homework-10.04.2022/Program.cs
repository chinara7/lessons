using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            /* Homework 1:
             Kiçik bir kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə edə biləcəyi əməliyyatları nömrələriylə göstərin.
             "Etmek istediyiniz emeliyyati secin:"
             "1. Toplama"
             "2. Çıxma"
             "3. Vurma"
             "4. Bölmə"
             İstifadəçi əməliyyatı seçəndən sonra a və b dəyərlərini rəqəm olaraq alın və əməliyyatı icra edib nəticəni göstərin.
             Sadəcə bir dənə bölmə əməliyyatında əgər b-nin dəyəri 1-dən kiçik olarsa ekrana "böləcəyiniz dəyər müsbət dəyər olmalıdır"
             yazdırın. 
           */
            #region Calculator if-else 
            //{
            //    // OPERAROTUN DAXİL EDİLMƏSİ
            //    Console.WriteLine("Hansı əməliyyatı etmək istəyirsinizsə ona uyğun rəqəmi qeyd edin:");
            //    StartPoint:

            //    Console.WriteLine("Toplama - 1");
            //    Console.WriteLine("Çıxma - 2");
            //    Console.WriteLine("Vurma - 3");
            //    Console.WriteLine("Bölmə - 4");
            //    int operation = Convert.ToInt32(Console.ReadLine());

            //    // burda sehv var
            //    if (operation < 1 || operation > 4)
            //    {
            //        Console.WriteLine("Səhv əməliyyat daxil etmisiniz. Yenidən seçin:");
            //        goto StartPoint;
            //    }

            //    // OPERANDLARIN DAXİL EDİLMƏSİ VƏ HESAB
            //    Console.WriteLine("İki ədəd daxil edin:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    decimal c;

            //    if (operation == 1)
            //    {
            //        c = a + b;
            //    }
            //    else if (operation == 2)
            //    {
            //        c = a - b;
            //    }
            //    else if (operation == 3)
            //    {
            //        c = a * b;
            //    }
            //    else
            //    {
            //        if (b < 0)
            //        {
            //            Console.WriteLine("b-nin dəyəri 1-dən böyük olmalıdır. Yenidən daxil edin:");
            //            b = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (b == 0)
            //        {
            //            Console.WriteLine("Sıfıra bölmə yoxdur. b-ni yenidən daxil edin:");
            //            b = Convert.ToInt32(Console.ReadLine());
            //        }
            //        c = a / b;
            //    }
            //    Console.WriteLine("Nəticə = " + c);
            //    Console.ReadLine();
            //}
            #endregion


            /* Homework 2:
              Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. 
              Yəni proqramda belə dəyişdirmək mümkün olmasın. Sonra istifadəçidən username və password'u daxil etməsini istəyin. 
              Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
              Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 
              3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın. 
            */

            #region MyRegion
            //{
            //    const string userName = "abc";
            //    const string password = "abc123";
            //    Console.WriteLine("İstifadəçi adını daxil edin:");
            //    string userName1 = Console.ReadLine();
            //    Console.WriteLine("Şifrəni daxil edin:");
            //    string password1 = Console.ReadLine();
            //    //  1-ci yoxlanış
            //    if (userName == userName1 && password == password1)
            //    {
            //        Console.WriteLine("Sistemə daxil olundu.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("İstifadəçi adı və ya şifrə səhvdir. Yenidən daxil edin.");
            //        Console.WriteLine("--------------------------------------------------------------");
            //        Console.WriteLine("İstifadəçi adını daxil edin:");
            //        userName1 = Console.ReadLine();
            //        Console.WriteLine("Şifrəni daxil edin:");
            //        password1 = Console.ReadLine();

            //        //  2-ci yoxlanış
            //        if (userName == userName1 && password == password1)
            //        {
            //            Console.WriteLine("Sistemə daxil olundu.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("İstifadəçi adı və ya şifrə səhvdir. Yenidən daxil edin.");
            //            Console.WriteLine("--------------------------------------------------------------");
            //            Console.WriteLine("İstifadəçi adını daxil edin:");
            //            userName1 = Console.ReadLine();
            //            Console.WriteLine("Şifrəni daxil edin:");
            //            password1 = Console.ReadLine();

            //            //  3-cü yoxlanış
            //            if (userName == userName1 && password == password1)
            //            {
            //                Console.WriteLine("Sistemə daxil olundu.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hesab bloklandı.");
            //            }
            //        }

            //    }

            //    Console.ReadLine();
            //}
            #endregion

            /* Homework 3:
              Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. 
              Toplama, çıxma, vurma və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. 
              Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
              istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək. 
            */

            #region Switch case
            //{
            //    RepeatStart:
            //    Console.WriteLine("Hansı əməliyyatı etmək istəyirsinizsə ona uyğun rəqəmi qeyd edin:");                
            //    Console.WriteLine("Toplama - 1");
            //    Console.WriteLine("Çıxma - 2");
            //    Console.WriteLine("Vurma - 3");
            //    Console.WriteLine("Bölmə - 4");
            //    int operation = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İki ədəd daxil edin:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int c;

            //    switch (operation)
            //    {
            //        case 1:
            //            c = a + b;
            //            Console.WriteLine("Nəticə = " + c);
            //            goto RepeatStart;
            //        case 2:
            //            c = a - b;
            //            Console.WriteLine("Nəticə = " + c);
            //            goto RepeatStart;
            //        case 3:
            //            c = a * b;
            //            Console.WriteLine("Nəticə = " + c);
            //            goto RepeatStart; 
            //        case 4:
            //            if (b == 0)
            //            {
            //                Console.WriteLine("b sifir olmaz yeniden daxil edin");
            //                goto RepeatStart;
            //            }
            //            c = a / b;
            //            Console.WriteLine("Nəticə = " + c);
            //            goto RepeatStart; 
            //        default:
            //            Console.WriteLine("Səhv əməliyyat daxil etmisiniz.");
            //            goto RepeatStart; 
            //    }
            //    Console.ReadLine();
            //}
            #endregion

        }
    }
}
