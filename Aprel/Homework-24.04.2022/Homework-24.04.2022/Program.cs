using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region izah
            //ArrayList arrList1 = new ArrayList();
            //int capacity = 0;
            //arrList1.Add("7");
            //arrList1.Add("true");
            //arrList1.Add("Chinara");
            //arrList1.Add("Elvin");

            //capacity = arrList1.Capacity;


            //ArrayList arrList2 = new ArrayList();
            //arrList2.Add(25);
            //arrList2.Add("Hello");
            //arrList2.Add(true);

            //arrList2.AddRange(arrList1);
            ////foreach (var item in arrList2)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(arrList1[2]);
            //ArrayList arr = new ArrayList();
            //arrList1.Reverse();
            //arrList1.Sort();
            //Console.ReadLine();
            #endregion


            #region Task-1
            /*
                İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = true
                Burdan çıxmaq üçün də "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın. yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
             */
             
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1 - Element elave et");
            Console.WriteLine(" 2 - Elementleri goster");
            Console.WriteLine(" 3 - Element axtar");
            Console.WriteLine(" 4 - Element editle");
            Console.WriteLine(" 5 - Element sil");
            Console.WriteLine(" 6 - Exit");
           
            ArrayList arrList = new ArrayList();
            object searchElement, editElement, clearElement;
            int elementIndex;
            string operation, answer;

            ChooseOperation:
            Console.WriteLine("Emeliyyat novunu secin:");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine("Element elave edin:");
                    arrList.Add(Console.ReadLine());
                    goto ChooseOperation;
                case "2":
                    Console.WriteLine("Elementlerin siyahisi");
                    foreach (var item in arrList)
                    {
                        Console.WriteLine("Element = {0}", item);
                    }
                    goto ChooseOperation;
                case "3":
                    Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                    searchElement = Console.ReadLine();
                    if (arrList.Contains(searchElement))
                    {
                        elementIndex = arrList.IndexOf(searchElement);
                        Console.WriteLine("Element tapildi : Index : {0} - Deyer: {1}", elementIndex, searchElement);
                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz element tapilmadi");
                    }
                    goto ChooseOperation;
                case "4":
                    Console.WriteLine("Editlemek istediyiniz elementi daxil edin: ");
                    searchElement = Console.ReadLine();
                    if (arrList.Contains(searchElement))
                    {
                        Console.WriteLine("{0} - elementini ne ile evezlemek isteyirsiniz?", searchElement);
                        editElement = Console.ReadLine();
                        elementIndex = arrList.IndexOf(searchElement);
                        arrList.RemoveAt(elementIndex);
                        arrList.Insert(elementIndex, editElement);
                        Console.WriteLine("{0} elementi {1} ile evezlendi.", searchElement, editElement);
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz element tapilmadi");
                    }
                    goto ChooseOperation; ;
                case "5":
                    DeleteElement:
                    Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                    answer = Console.ReadLine();
                    if (answer.ToUpper() == "H") 
                    {
                        arrList.Clear();
                    }                    
                    else if (answer.ToUpper() == "Y")
                    {
                        Console.WriteLine("Silmek istediyiniz elementi daxil edin:");
                        clearElement = Console.ReadLine();
                        if (arrList.Contains(clearElement))
                        {
                            arrList.Remove(clearElement);
                            Console.WriteLine("{0} - elementi silindi", clearElement);
                        }
                        else
                        {
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Duzgun emeliyyat daxil edin : H/Y");
                        goto DeleteElement;
                    }
                    goto ChooseOperation; ;
                case "6":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Bele emeliyyat movcud deyil. Yeniden cehd edin:");
                    goto ChooseOperation;                    
            }
            Console.ReadLine();
            #endregion

        }
    }
}
