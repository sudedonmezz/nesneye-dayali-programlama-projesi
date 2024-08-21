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
    public class point3d : point
    {
        int x;
        int y;
        int z;

        public point3d():base()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public point3d(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int Z { get => z; set => z = value; }
        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }
    }
}
