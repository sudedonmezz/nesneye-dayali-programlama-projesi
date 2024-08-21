﻿using System;
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

    //yuzey kalınlığı sıfır olan dikdortgen prizma
    
    public class yuzey
    {
        point3d m;
       
        int yukseklik;
        int uzunluk; //prizma uzun kenar

        public yuzey()
        {
            m = new point3d();
            yukseklik = 0;
            uzunluk = 0;
        }
        public yuzey(int yukseklik,int uzunluk,point3d m)
        {
            this.yukseklik = yukseklik;
            this.uzunluk = uzunluk;
            this.m = m;
        }

        public int Yukseklik { get => yukseklik; set => yukseklik = value; }
        public int Uzunluk { get => uzunluk; set => uzunluk= value; }
        internal point3d M { get => m; set => m = value; }

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
