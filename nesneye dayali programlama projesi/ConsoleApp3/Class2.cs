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
    public class point
    {
        int x;
        int y;
        int z;

        public point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public point(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public void oku()
        {
            Console.WriteLine("Noktanın X koordinatını girin");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Noktanın Y koordinatını girin");
            Y = int.Parse(Console.ReadLine());
            
        }
    }
}
