using System;
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
            #region if else
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

            //if (capital == "ankara"&country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1,exam2,exam3,average;
            //string result="hata";
            //Console.Write("Sınav 1 notunuzu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 notunuzu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 notunuzu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+ exam2+ exam3)/ 3;
            //Console.WriteLine(" Bu üç sınav ortalamanız :"+ average);
            //if (average >= 0 & average < 50)
            //{
            //    result = "Notunuz çok kötü. Bu derse daha çok çalışmalısınız.";
            //}
            //if (average >= 50 & average < 85)
            //{
            //    result = "Notunuz ortalama.";
            //}
            //if(average>=85 &average<=100)
            //{
            //    result = "Tebrikler notunuz gayet iyi";
            //}
            //Console.WriteLine(result);



            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();


            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "kocaeli")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lüfen 1. sayıyı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lüfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan " + result);



            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çift sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
            ////}

            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray"); 
            //}
            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}


            //Console.WriteLine("+++++++C# eğitim kampı restoran+++++++");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine();

            //string choose;
            //Console.Write("Sipariş vermek istediğiniz kategorinin numarasını giriniz: ");
            //choose=Console.ReadLine();
            //if(choose=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("+++++ Ana yemekler +++++");
            //    Console.WriteLine("1-Köri Soslu Tavuk ");
            //    Console.WriteLine("2-Kıxartma Tabağı");
            //    Console.WriteLine("3-Fırında Somon ");
            //}
            //if (choose=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("+++++ Çorbalar +++++");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");

            //}
            //if (choose == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("+++++ Tatlılar +++++");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Puding");
            //    Console.WriteLine("3-Kemalpaşa");
            //    Console.WriteLine("4-Şekerpare");

            //}
            //if (choose == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("+++++ İçecekler +++++");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Soğuk Çay");

            //}

            #endregion

            #region Switch Case  

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık");
            //break;
            //    default:Console.WriteLine("Hatalı bir giriş yaptınız");
            //break;
            //}

            #endregion

            #region Switch-Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());



            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: "+        result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: "        + result);
            //        break;
            //    case '*':
            //        result = number1 + number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 + number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}
            #endregion

            Console.Read();
        }
    }
}
