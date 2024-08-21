using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
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
    public class cember //tek boyutlu
    {
        point m;
        int r;

        public cember()
        {
            m = new point();
            r = 0;
        }
        public cember(int r,point m)
        {
            this.m = m;
            this.r = r;
        }
        

        public int R { get => r; set => r = value; }
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
                m = new point(x, y,0);
                Console.WriteLine("Girilen koordinat: ({0},{1})", m.X, m.Y);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }

        }
    }
}
