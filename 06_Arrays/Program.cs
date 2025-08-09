using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,lacivert,turuncu
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[elemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Lacivert";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);
            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "İstanbul";
            //cities[3] = "Ankara";
            //cities[4] = "Kahire";
            //Console.WriteLine(cities[4]);
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[4] = 796;
            //numbers[5] = 4;
            //numbers[6] = 5;
            //numbers[7] = 556;
            //numbers[8] = 57;
            //numbers[9] = 575;
            //Console.WriteLine(numbers[5]);
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);


            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Lacivert", "Beyaz", "Kırmızı", "Yeşil", "Mavi", "Turuncu" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);

            //}
            //int[] numbers = { 4, 65, 67, 89, 876, 456, 765, 32, 12, 43, 5 };
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }

            //}
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i <symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);


            //}
            //int[] myArray = { 47, 45, 456, 224, 2424, 578, 987, 45678 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)

            //{

            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];

            //    }

            //}
            //Console.WriteLine(maxNumber);
            //int[] myArray = { 47, 45, 456, 224, 2424, 578, 987, 45678 };
            //Console.WriteLine(myArray.Length);
            //int[] myArray = { 47, 45, 456, 224, 2424, 578, 987, 45678 };
            //Array.Sort(myArray);
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);

            //}

            #endregion
            #region Dizi Metotlar
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya", "" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            //int[] numbers = { 45, 24, 67, 789, 753, 789, 5788, 8846 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($" Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,0};
            //Console.WriteLine("Çift Sayılar");
           
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }


            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }


            //}
            #endregion
            Console.Read();
        }
    }
}
