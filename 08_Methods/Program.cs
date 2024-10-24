using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metotlar
            //// ()
            //// Geriye değer döndürmeyen metotlar
            ////Customer -->> Listele,ekle,sil,güncelle
            ////void
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}//Bu şekilde çalıştırıldığında ekrana herhangi bir şey yazmaz çünkü metot henüz çağırılmadı çağırlmadığı sürece metotun altında yeşil çizgi bulunur yani metot tanımlandı ama henüz kullanılmadı anlamında
            //CustomerList();//4 defa çağırdık 4 defa yazar
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y=2;    
            //    int z = x+y;
            //    Console.WriteLine(z);   
            //}
            //sum();


            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");//artık bu methodu çağırdığımızda bir girdi parametresi ister

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar
            //void sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);  
            //}

            //sum(3, 4, 5);

            #endregion

            #region Geriye değer döndüren metotlar
            // artık void yok tür belirtilmeli
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();//Ekrana bir şey yazmaz , yazma komutu yok fakat ekrana bir şey döner

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " +  surname;
            //}
            //Console.WriteLine(StudentCard());       



            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke " + countryName + "Başkent " + capital + "Bayrak Rengi " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adını giriniz: ");
            //x= Console.ReadLine();     

            //Console.WriteLine("Başkenti giriniz: ");
            //y = Console.ReadLine(); 

            //Console.WriteLine("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));//bu şekilde de girebiliriz



            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(3, 2));
            //Console.WriteLine(Sum(7, 2));
            //Console.WriteLine(Sum(6, 2));
            #endregion


            #region Örnek Uygulama 
            string ExamResult(string student, int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
                }
                else
                {
                    return student+" isimli öğrenci sınavı geçemedi" +" Ortalama: " +result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));




            #endregion

            Console.Read();
        }
    }
}
