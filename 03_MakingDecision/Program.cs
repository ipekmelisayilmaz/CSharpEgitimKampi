﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")// & (mantıksal ve) c#'ın yeni sürümlerinde tek şekilde de kullanılabilir (&&) gerek yok
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayiyi giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";
            //Console.WriteLine("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3; //işlem önceliğinden () içine almayı unutma
            //Console.WriteLine("Sınavların ortalaması : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result="Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result="Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //Console.WriteLine(result) ***Bu yazım hata verir çünkü  başta result'a bir değer ataması yapılmadı beklenen değerler(ifler) dışında bir değer girilirse result nasıl yazdırılacak ?
            //*** iki seçenek var ya başlangıçta result'a bir değer atması yap ya da else ile resulta değer ata

            //string city;
            //Console.WriteLine("Bir şehir giriniz");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")// |(mantıksal veya) da (mantıksal ve) & gibi tek yazılabilir c# yeni versiyonu

            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("Kullanıcı adı giriniz");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //int number1;
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //int number2;
            //number2 = int.Parse(Console.ReadLine());

            //int result;
            //result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);


            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi;
            //sayi = int.Parse(Console.ReadLine());
            //if(sayi%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;//Char tipi 'tek karakter' dışında tip veri girilirse hata verir , buradaki değerler dışındak char girilirse hiçbir çıktı vermez
            //Console.WriteLine("Lütfen takım sembolünü giriniz");
            //team=char.Parse(Console.ReadLine());
            //if(team=='g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");

            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");

            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş" +
            //        "");

            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if(menuItem== "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorba");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case
            //Console.WriteLine("Lütfen ay girişi yapınız");
            //int monthNumber=int.Parse(Console.ReadLine());
            //switch(monthNumber)
            //{

            //    case 1:Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("Hatalı veri girişi");break;

            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.sayıyı giriniz");
            //number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam: " +result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion

            Console.ReadKey();
        }
    }
}


