using System;
using System.Collections.Generic;
using System.Linq;
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
   
    public class dikdortgenprizma
    {
        int uzunluk;
        int genislik;
        int yukseklik;
        point3d m;

        public dikdortgenprizma()
        {
            uzunluk = 0;
            genislik = 0;
            yukseklik = 0;
            m = new point3d();
        }

        public dikdortgenprizma(int uzunluk,int genislik,int yukseklik,point3d m)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.m = m;

        }
        public int Uzunluk { get => uzunluk; set => uzunluk = value; }
        public int Genislik { get =>genislik; set => genislik = value; }
        public int Yukseklik { get => yukseklik; set => yukseklik = value; }
        internal point3d M { get => m; set =>m = value; }


        public void oku()
        {
            int x, y, z;
            Console.Write("X koordinatını giriniz: ");
            bool successX = int.TryParse(Console.ReadLine(), out x);

            Console.Write("Y koordinatını giriniz: ");
            bool successY = int.TryParse(Console.ReadLine(), out y);

            Console.Write("Z koordinatını giriniz: ");
            bool successZ = int.TryParse(Console.ReadLine(), out z);

            if (successX && successY && successZ)
            {
                M = new point3d(x, y, z);
                Console.WriteLine("Girilen koordinat: ({0},{1},{2})", m.X, m.Y, m.Z);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }

        }



    }
}
