using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
    public class dikdortgen
    {
        Point nokta;
        int en;
        int boy;
        

        public dikdortgen() 
        {
            nokta = new Point();
            en = 0;
            boy = 0;
        }
        public dikdortgen(Point nokta, int en, int boy)
        {
            this.nokta = nokta;
            this.en = en;
            this.boy = boy;
        }
        public Point Nokta
       
           {get => nokta;set => nokta = value;}
        
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
   
    public void oku()
        {
            int x, y;
            Console.Write("X koordinatını giriniz: ");
            bool successX = int.TryParse(Console.ReadLine(), out x);

            Console.Write("Y koordinatını giriniz: ");
            bool successY = int.TryParse(Console.ReadLine(), out y);

            if (successX && successY)
            {
                nokta = new Point(x, y);
                Console.WriteLine("Girilen koordinat: ({0},{1})", nokta.X,nokta.Y);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }

        }

       
    }
    

}
