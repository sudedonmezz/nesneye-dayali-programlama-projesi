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

    public class silindir
    {
        point3d m;
        int r;
        int h;
        public silindir()
        {
           M = new point3d();
            R = 0;
            H = 0;
        }
        public silindir(point3d m,int r,int h)
        {
            this.m = m;
            this.r = r;
            this.h = h;
        }
        internal point3d M { get => m; set => m = value; }
        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }


        public void oku()
        {
            int x, y, z;
            Console.Write("X koordinatını giriniz: ");
            bool successX = int.TryParse(Console.ReadLine(), out x);

            Console.Write("Y koordinatını giriniz: ");
            bool successY = int.TryParse(Console.ReadLine(), out y);

            Console.Write("Y koordinatını giriniz: ");
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
