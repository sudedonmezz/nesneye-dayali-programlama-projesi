using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…proje...:
** ÖĞRENCİ ADI.....sude dönmez..........:
** ÖĞRENCİ NUMARASI.: b221210581
** DERS GRUBU……A grubu……:
YOUTUBE LİNKİ… …:
****************************************************************************/

namespace sude
{
    class sude
    {
        static void Main(string[] args)
        {
            /*      Console.WriteLine("----------------------------------------------");   //dikdortgen-dikdortgen carpismasi icin


                  dikdortgen a1 = new dikdortgen();
                  dikdortgen b1 = new dikdortgen();

                  a1.oku();
                  Console.WriteLine("ilk dikdortgenin en bilgisini giriniz:");
                  a1.En = int.Parse(Console.ReadLine());
                  Console.WriteLine("ilk dikdortgenin boy bilgisini giriniz:");
                  a1.Boy = int.Parse(Console.ReadLine());
                  Console.WriteLine("----------------------------------------------");
                  b1.oku();
                  Console.WriteLine("ikinci dikdortgenin en bilgisini giriniz:");
                  b1.En = int.Parse(Console.ReadLine());
                  Console.WriteLine("ikinci dikdortgenin boy bilgisini giriniz:");
                  b1.Boy = int.Parse(Console.ReadLine());


                if(  Carpisma.dikdortgenCarp(a1,b1))
                  {
                      Console.WriteLine("carpisiyor.");
                  }
                  else
                  {
                      Console.WriteLine("carpismiyor.");
                  } 
            */
            /* Console.WriteLine("----------------------------------------------");    //kure nokta carpismasi icin

             kure a1 = new kure();
             a1.oku();
             Console.WriteLine("kurenin yaricapini giriniz:");
             a1.R = int.Parse(Console.ReadLine());

             point b1 = new point();
             b1.oku();

             if(Carpisma.kurenoktaCarp(a1,b1))
             {
                 Console.WriteLine("carpisiyor.");
             }
             else
             {
                 Console.WriteLine("carpismiyor");
             }
            */
            /*  Console.WriteLine("----------------------------------------------");   //kure-kure carpismasi icin
              kure a1 = new kure();
              kure b1 = new kure();
              a1.oku();
              Console.WriteLine("ilk kürenin yaricapi:");
              a1.R = int.Parse(Console.ReadLine());
              Console.WriteLine("----------------------------------------------");
              Console.WriteLine("ikinci kurenin degerleri:");
              b1.oku();
              Console.WriteLine("ikinci kurenin yaricapi: ");
              b1.R = int.Parse(Console.ReadLine());

              if(Carpisma.kurekureCarp(a1,b1))
              {
                  Console.WriteLine("carpisiyor.");
              }
              else
              {
                  Console.WriteLine("carpismiyor");
              } 
            */

            /*
            Console.WriteLine("----------------------------------------------");   //cember cember carpismasi icin
            cember a1 = new cember();
            cember b1 = new cember();

            a1.oku();
            Console.WriteLine("cemberin yaricapini giriniz:");
            a1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("2. cemberin bilgileri:");
            b1.oku();
            Console.WriteLine("cemberin yaricapini giriniz:");
            b1.R = int.Parse(Console.ReadLine());

            if(Carpisma.cembercemberCarp(a1,b1))
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("Carpismiyor");
            }
         
             */

            /*
            Console.WriteLine("----------------------------------------------");     //cember nokta carpismasi icin
            cember a1 = new cember();
            point b1 = new point();

            a1.oku();
            Console.WriteLine("cemberin yaricapi:");
            a1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("noktanın koordinatlari:");
            b1.oku();

            if(Carpisma.cembernoktaCarp(a1,b1))
            {
                Console.WriteLine("carpisiyor.");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }

            */

            /*

            Console.WriteLine("----------------------------------------------");  //silindir silindir carpismasi icin
            silindir a1 = new silindir();
            silindir b1 = new silindir();
            a1.oku();
            Console.WriteLine("ilk silindirin yaricapi:");
            a1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("ilk silindirin yuksekligi");
            a1.H = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("ikinci silindir degerleri:");
            b1.oku();
            Console.WriteLine("ikinci silindirin yaricapi:");
            b1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci silindirin yuksekligi:");
            b1.H = int.Parse(Console.ReadLine());

            if(Carpisma.silindirsilindirCarp(a1,b1))
                {
                Console.WriteLine("carpisiyorlar");
            }
            else
            {
                Console.WriteLine("carpismiyorlar");
            }

            */
            /*
                        Console.WriteLine("----------------------------------------------"); //nokta silindir çarpışma denetimi
                        point a1 = new point();
                        a1.oku();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("silindir bilgileri:");
                        silindir b1 = new silindir();
                        b1.oku();
                        Console.WriteLine("silindirin yaricapini girin:");
                        b1.R = int.Parse(Console.ReadLine());
                        Console.WriteLine("silindirin yuksekligini girin:");
                        b1.H = int.Parse(Console.ReadLine());

                        if(Carpisma.silindirnoktaCarp(b1,a1))
                        {
                            Console.WriteLine("carpisiyorlar");

                        }
                        else
                        {
                            Console.WriteLine("carpismiyorlar.");
                        }

                        */


            /* 
             Console.WriteLine("----------------------------------------------");      //dikdortgen cember carpisma denetimi
             dikdortgen a1 = new dikdortgen();
             a1.oku();
             Console.WriteLine("dikdortgenin eni:");
             a1.En = int.Parse(Console.ReadLine());
             Console.WriteLine("dikdörtgenin boyu:");
             a1.Boy = int.Parse(Console.ReadLine());
             Console.WriteLine("----------------------------------------------");
             Console.WriteLine("çember bilgileri:");
             cember b1 = new cember();
             b1.oku();
             Console.WriteLine("çemberin yaricapi:");
             b1.R = int.Parse(Console.ReadLine());

             if(Carpisma.dikdortgencemberCarp(a1,b1))
             {
                 Console.WriteLine("carpisiyor");
             }
             else
             {
                 Console.WriteLine("carpismiyor");
             }

 */
            /*
            Console.WriteLine("----------------------------------------------"); //kure silindir carpismasi

            kure a1 = new kure();
            a1.oku();
            Console.WriteLine("kurenin yaricapini giriniz:");
            a1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("silindir bilgileri:");
            silindir b1 = new silindir();
            b1.oku();
            Console.WriteLine("silindir yarıpçap:");
            b1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("silindir yuksekligi:");
            b1.H = int.Parse(Console.ReadLine());

            if(Carpisma.kuresilindirCarp(a1,b1))
            {
                Console.WriteLine("carpisiyor.");
            }
            else
            {
                Console.WriteLine("carpismiyor.");
            }

*/

            /*
                        Console.WriteLine("----------------------------------------------"); //nokta dortgen carpismasi

                        point a1 = new point();
                        a1.oku();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("dortgen bilgileri:");
                        dortgen b1 = new dortgen();
                        b1.oku();
                        Console.WriteLine("dortgenin genisligi:");
                        b1.Genislik = int.Parse(Console.ReadLine());
                        Console.WriteLine("dortgenin yuksekligi:");
                        b1.Yukseklik = int.Parse(Console.ReadLine());

                        if(Carpisma.noktadortgenCarp(a1,b1))
                        {
                            Console.WriteLine("carpisiyor");
                        }
                        else
                        {
                            Console.WriteLine("carpismiyor");
                        }
            */


            /*
            Console.WriteLine("----------------------------------------------"); //nokta-dikdortgen prizmasi carpismasi
            point a1 = new point();
            a1.oku();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("dikdortgen prizmasi bilgileri:");
            dikdortgenprizma b1 = new dikdortgenprizma();
            b1.oku();
            Console.WriteLine("dikdortgen prizmasinin yuksekligi:");
            b1.Yukseklik = int.Parse(Console.ReadLine());
            Console.WriteLine("dikdortgen prizmasinin uzunlugu:");
            b1.Uzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("dikdortgen prizmasinin genisligi:");
            b1.Genislik = int.Parse(Console.ReadLine());

            if(Carpisma.noktadikdortgenpCarp(b1,a1))
            {
                Console.WriteLine("carpisiyor.");
            }
            else
            {
                Console.WriteLine("carpismiyor.");
            }

            */

            /*    Console.WriteLine("----------------------------------------------"); //dikdortgenp-dikdortgenp carpismasi
                dikdortgenprizma a1 = new dikdortgenprizma();
                dikdortgenprizma b1 = new dikdortgenprizma();

                a1.oku();
                Console.WriteLine("dikdortgen prizmasinin uzunlugu:");
                a1.Uzunluk = int.Parse(Console.ReadLine());
                Console.WriteLine("dikdortgen prizmasinin genisligi:");
                a1.Genislik= int.Parse(Console.ReadLine());
                Console.WriteLine("dikdortgen prizmasinin yuksekligi:");
                a1.Yukseklik= int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("2.dikdörtgen prizmasinin bilgileri:");
                b1.oku();
                Console.WriteLine("2.dikdortgen prizmasinin uzunlugu:");
                b1.Uzunluk = int.Parse(Console.ReadLine());
                Console.WriteLine("2.dikdortgen prizmasinin genisligi:");
                b1.Genislik = int.Parse(Console.ReadLine());
                Console.WriteLine("2.dikdortgen prizmasinin yuksekligi:");
                b1.Yukseklik = int.Parse(Console.ReadLine());

                if(Carpisma.dikdortgenpdikdortgenpCarp(a1,b1))
                {
                    Console.WriteLine("carpisiyor");
                }
                else
                {
                    Console.WriteLine("carpismiyor");
                }
    */

            /*
            Console.WriteLine("----------------------------------------------"); //kure dikdortgen prizma carpisma
            kure a1 = new kure();
            a1.oku();
            Console.WriteLine("kurenin yaricapi:");
            a1.R = int.Parse(Console.ReadLine());


            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("dikdortgen prizma bilgiler:");
            dikdortgenprizma b1 = new dikdortgenprizma();
            b1.oku();
            Console.WriteLine("dikdortgen prizmasinin uzunlugu:");
            b1.Uzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("dikdortgen prizmasinin genisligi:");
            b1.Genislik = int.Parse(Console.ReadLine());
            Console.WriteLine("dikdortgen prizmasinin yuksekligi:");
            b1.Yukseklik = int.Parse(Console.ReadLine());

            if(Carpisma.kuredikdortgenpCarp(a1,b1))
            {
                Console.WriteLine("Carpisiyor");
            }

*/
            /*
            Console.WriteLine("----------------------------------------------"); //yuzey kure carpisma
            kure a1 = new kure();
            a1.oku();
            Console.WriteLine("kurenin yaricapi:");
            a1.R = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("yuzey bilgileri:");
            yuzey b1 = new yuzey();
            b1.oku();
            Console.WriteLine("yuzeyin yuksekligi:");
            b1.Yukseklik = int.Parse(Console.ReadLine());
            Console.WriteLine("yuzeyin uzunlugu:");
            b1.Uzunluk = int.Parse(Console.ReadLine());

            if(Carpisma.yuzeykureCarp(b1,a1))
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor.");
            }
            */
            /*
                        Console.WriteLine("----------------------------------------------"); //yuzey dikdortgenp carpisma
                        yuzey a1 = new yuzey();
                        a1.oku();
                        Console.WriteLine("yuzeyin uzunlugunu giriniz:");
                        a1.Uzunluk = int.Parse(Console.ReadLine());
                        Console.WriteLine("yuzeyin yuksekligini giriniz:");
                        a1.Yukseklik = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("dikdörtgen prizmasi bilgileri");
                        dikdortgenprizma b1 = new dikdortgenprizma();
                        b1.oku();
                        Console.WriteLine("dikdörtgenp nin uzunlugunu girin:");
                        b1.Uzunluk= int.Parse(Console.ReadLine());
                        Console.WriteLine("dikdörtgen p nin yuksekligini girin:");
                        b1.Yukseklik= int.Parse(Console.ReadLine());
                        Console.WriteLine("dikdörtgen p nin genisligini girin:");
                        b1.Genislik= int.Parse(Console.ReadLine());

                        if(Carpisma.yuzeydikdortgenpCarp(b1,a1))
                        {
                            Console.WriteLine("carpisiyor");
                        }
                        else
                        {
                            Console.WriteLine("carpismiyor.");
                        }
            */

            /*   Console.WriteLine("----------------------------------------------"); //yuzey silindir carpisma
               yuzey a1 = new yuzey();
               a1.oku();
               Console.WriteLine("yuzeyin uzunlugunu giriniz:");
               a1.Uzunluk = int.Parse(Console.ReadLine());
               Console.WriteLine("yuzeyin yuksekligini giriniz:");
               a1.Yukseklik = int.Parse(Console.ReadLine());
               Console.WriteLine("----------------------------------------------");
               Console.WriteLine("silindir bilgileri:");
               silindir b1 = new silindir();
               b1.oku();
               Console.WriteLine("silindirin yarıçapını girin:");
               b1.R= int.Parse(Console.ReadLine());
               Console.WriteLine("silindirin uzunlugunu girin:");
               b1.H= int.Parse(Console.ReadLine());

               if(Carpisma.yuzeysilindirCarp(a1,b1))
               {
                   Console.WriteLine("carpisiyor.");
               }
               else
               {
                   Console.WriteLine("carpismiyor");
               }
   */






            /*

            if (Carpisma.dikdortgenCarp(new dikdortgen(new Point(5, 5), 8, 9), (new dikdortgen(new Point(4, 4), 3, 5))))    //dikdortgen-dikdortgen carpisma ornegi
            {
                Console.WriteLine("carpisiyorlar");
            }
            else
            {
                Console.WriteLine("carpismiyorlar");
            }

            */

            /*   if (Carpisma.kurenoktaCarp(new kure(new point3d(7, 5, 8), 9), new point(8, 9, 7)))     //kure nokta carpisma ornegi
               {
                   Console.WriteLine("carpisiyor");
               }
               else
               {
                   Console.WriteLine("carpismiyor");
               }

               */

            /*   
              if(Carpisma.kurekureCarp(new kure(new point3d(9,6,5),3),new kure(new point3d(2,4,1),6)))    //kure kure carpisma ornegi
              {
                  Console.WriteLine("carpisiyor");
              }
              else
              {
                  Console.WriteLine("carpismiyor");
              }
            */
/*
            if (Carpisma.cembercemberCarp(new cember(4,new point(5,4,0)), new cember(6,new point(7,5,0))))    //cember cember carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.cembernoktaCarp(new cember(4, new point(5, 4, 0)),  new point(7, 5, 0)))    //cember nokta carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.silindirsilindirCarp(new silindir(new point3d(5,4,9),9,5), new silindir(new point3d(5, 4, 9), 9, 5)))    //silindir silindir carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*

            if (Carpisma.silindirnoktaCarp(new silindir(new point3d(5, 4, 9), 9, 5),(new point(5, 4, 9))))    //silindir nokta carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*

            if (Carpisma.dikdortgencemberCarp(new dikdortgen(new Point(4,5),6,6), new cember(4, new point(5, 4, 0))))    //cember dikdortgen carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*

            if (Carpisma.kuresilindirCarp(new kure(new point3d(5,6,7),9), new silindir(new point3d(5, 4, 9), 9, 5)))    //silindir kure carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            //Carpisma.noktadortgenCarp(new point(5,7,6)),new dortgen(6,7,new point(4,5,7))
            if (Carpisma.noktadortgenCarp(new point(5, 4, 0), new dortgen(5,6,new point(7,6,4))) )          //nokta dortgen carpisma ornegi
               
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*

            if (Carpisma.noktadikdortgenpCarp(new dikdortgenprizma(5,6,7,new point3d(6,5,3)), new point(5, 4, 0)))          //nokta dortgenp carpisma ornegi

            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.dikdortgenpdikdortgenpCarp(new dikdortgenprizma(5, 6, 7, new point3d(6, 5, 3)), new dikdortgenprizma(5, 6, 7, new point3d(6, 5, 3))))          //dortgenp dortgenp carpisma ornegi

            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.kuredikdortgenpCarp(new kure(new point3d(5, 6, 7), 9), new dikdortgenprizma(5, 6, 7, new point3d(6, 5, 3))))         //kure dikdortgenp
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");

            }
*/
/*
            if (Carpisma.yuzeykureCarp(new yuzey(6,5,new point3d(6,4,2)), new kure(new point3d(7, 5, 8), 9)))     //kure yuzey carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.yuzeydikdortgenpCarp(new dikdortgenprizma(5, 6, 7, new point3d(6, 5, 3)), new yuzey(6, 5, new point3d(6, 4, 2))) )    //dikdortgenp yuzey carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }
*/
/*
            if (Carpisma.yuzeysilindirCarp(new yuzey(6, 5, new point3d(6, 4, 2)), new silindir(new point3d(5, 4, 9), 9, 5)))    //silindir yuzey carpisma ornegi
            {
                Console.WriteLine("carpisiyor");
            }
            else
            {
                Console.WriteLine("carpismiyor");
            }

            */
        }


    }

}
