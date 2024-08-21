using System;
using System.Collections.Generic;
using System.Drawing;
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
   
    public class dortgen
    {
       

        int genislik, yukseklik;
        point m;

        public dortgen()
        {
            int genislik = 0;
            int yukseklik = 0;

            m = new point();

        }
        public dortgen(int genislik,int yukseklik,point m)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.m = m;

        }
        public int Genislik { get => genislik; set => genislik = value; }
        public int Yukseklik { get => yukseklik; set => yukseklik = value; }
        internal point M { get => m; set => m = value; }

        public void oku()
        {
            int x, y;
            Console.Write("X koordinatını giriniz: ");
            bool successX = int.TryParse(Console.ReadLine(), out x);

            Console.Write("Y koordinatını giriniz: ");
            bool successY = int.TryParse(Console.ReadLine(), out y);

            if (successX && successY)
            {
                M = new point(x, y,0);
                Console.WriteLine("Girilen koordinat: ({0},{1})", M.X, M.Y);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }

        }

    }
}
