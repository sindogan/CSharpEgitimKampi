﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Foreach(1;2;3;4)
            //1:Değişken Türü
            //2:Değişken Adı
            //3: In
            //4:Liste,Koleksiyon,Dizi
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);

            //}
            //int[] numbers = { 45, 78, 987, 635, 74,87878};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //int[] numbers = { 45, 78, 987, 635, 74, 87878 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);

            //    }
            //}
            //int[] numbers = { 45, 78, 987, 635, 74, 87878 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6

            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion
            #region Örnek Sınav Sistemi uygulaması
            //Console.Write("***** C# Eğitim Kampı Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıf Öğrenci Sayısı input
            //Console.WriteLine("-------------------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------------");
            ////öğrenci isimleri ve not ortalama dizileri
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz:");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamPoint = 0;
            //    //her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamPoint += value;//toplama not

            //    }
            //    studentExamAvg[i] = totalExamPoint / 3;

            
            //}

            ////öğrencilerin ortalaması ve geçip geçmedikleri
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-------------------------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçemedi");


            //    }
            //    Console.WriteLine("-------------------------------------------");

            //}
            #endregion

            Console.Read();
        }
    }
}
