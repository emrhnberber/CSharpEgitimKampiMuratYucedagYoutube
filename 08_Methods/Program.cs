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
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyn Metotlar
            //Void

            //void CustoerList()
            //{
            //    Console.WriteLine("Emirhan Berber");
            //    Console.WriteLine("Nurhan Berber");
            //    Console.WriteLine("Mustafa Berber");
            //}

            //CustoerList();
            //CustoerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Emirhan");



            //void CustomerCard(string customerName, string customerSurname) { 

            //    Console.WriteLine("Müşteri:" + customerName + customerSurname);
            //}

            //CustomerCard("Emirhan", "Berber");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 2);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Emirhan";
            //    string surname = "Berber";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string personalInfo(string name, string surname, string carrierinfo)
            //{
            //    string personalCard = "İsim: " + name + " - Soyisim: " + surname + " - Kariyer Geçmişi: " + carrierinfo;
            //    return personalCard;
            //}

            //Console.Write("İsminizi Giriniz:");
            //string x = Console.ReadLine();

            //Console.Write("Soyisim Giriniz:");
            //string y = Console.ReadLine();

            //Console.Write("Geçmiş İş Tecrübelerinizi Giriniz:");
            //string z = Console.ReadLine();

            //Console.WriteLine(personalInfo(x, y, z));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));


            #endregion

            #region Ornek Uygulama

            //string alandaPersonalAnalysc(string pFullName, int totalpozitivestars, int totalnegativestars)
            //{
            //    int personalAvarage = totalpozitivestars + totalnegativestars;
            //    personalAvarage = personalAvarage / 2;

            //    Console.WriteLine("Bu hafta senin performans sonucun: " + personalAvarage);
            //    if (personalAvarage >= 80 )
            //    {
            //        return "Haftanın en iyileri arasındasın! Sonuçlar için takipte kal.";
            //    }
            //    else
            //    {
            //        return "Maalesef başarısız. Haftaya şansını tekrar dene :/";
            //    }

            //}

            //Console.WriteLine(alandaPersonalAnalysc("Emirhan Berber", 50, 100));
            #endregion

            Console.Read(); 
        }
    }
}
