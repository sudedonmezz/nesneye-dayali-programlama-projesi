using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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
    public static class Carpisma
    {
        public static bool dikdortgenCarp(dikdortgen a1, dikdortgen b1)
        {
            int Xa = a1.Nokta.X + a1.En / 2; //orta nokta
            int Ya = a1.Nokta.Y + a1.Boy / 2;
            int Xb = b1.Nokta.X + b1.En / 2;
            int Yb = b1.Nokta.Y + b1.Boy / 2;

            if (Math.Abs(Xa - Xb) < (a1.En / 2 + b1.En / 2) && Math.Abs(Ya - Yb) < (a1.Boy / 2 + b1.Boy / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kurenoktaCarp(kure a1,point b1)
        {
            //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
            float uzaklik = (float)Math.Sqrt(Math.Pow(a1.M.X - ((b1.X)), 2) + Math.Pow(a1.M.Y-(b1.Y),2)+ Math.Pow(a1.M.Z-(b1.Z),2));
            //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.

            if(uzaklik<=a1.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kurekureCarp(kure a1, kure b1)
        {
            float uzaklik=(float)Math.Sqrt(Math.Pow((a1.M.X-b1.M.X),2 )+ Math.Pow((a1.M.Y-b1.M.Y),2) + Math.Pow((a1.M.Z-b1.M.Z),2));
        if((a1.R+b1.R)>(int)uzaklik)
            {
                return true;
            }
            else
            {
                return false;
            }
       
        
        }

        public static bool cembercemberCarp(cember a1,cember b1)
        {
            float uzaklik = (float)Math.Sqrt(Math.Pow((a1.M.X - b1.M.X), 2) + Math.Pow((a1.M.Y - b1.M.Y), 2));

            if((a1.R+b1.R)>uzaklik)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool cembernoktaCarp(cember a1, point b1)
        {
            //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
            float uzaklik = (float)Math.Sqrt(Math.Pow(a1.M.X - ((b1.X)), 2) + Math.Pow(a1.M.Y - (b1.Y), 2) );
            //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.

            if (uzaklik <= a1.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool silindirsilindirCarp(silindir a1,silindir b1)
        {
            point3d pa = new point3d(a1.M.X, a1.M.Y + a1.H / 2, a1.M.Z);
            point3d pb = new point3d(b1.M.X, b1.M.Y + b1.H / 2, b1.M.Z);

            float uzaklik = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) + Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));


            if ((a1.R + b1.R) > (int)uzaklik && Math.Abs(pa.Y - pb.Y) < ((a1.H + b1.H) / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool silindirnoktaCarp(silindir a1, point b1)
        {
            point3d pa = new point3d(a1.M.X, a1.M.Y + a1.H / 2, a1.M.Z);

            float uzaklik = (float)Math.Sqrt(Math.Pow((pa.X - b1.X), 2) + Math.Pow((pa.Y - b1.Y), 2) + Math.Pow((pa.Z - b1.Z), 2));

            if ((a1.R) >= (int)uzaklik )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool dikdortgencemberCarp(dikdortgen a1, cember b1)
        {
            int x1 = a1.Nokta.X - a1.En / 2; //sol alt x köşe koordinatı
            int y1 = a1.Nokta.Y - a1.Boy / 2; //sol alt köşe y koordinatı

            int x2 = a1.Nokta.X + a1.En / 2; //sağ üst kşe x koordinatı
            int y2 = a1.Nokta.Y + a1.Boy / 2; //sağ üst köşe y koordinatı

            int nearestX = Math.Max(x1, Math.Min(b1.M.X, x2));
            int nearestY = Math.Max(y1, Math.Min(b1.M.Y, y2));

            double distance = Math.Sqrt((nearestX - b1.M.X) * (nearestX - b1.M.X) + (nearestY - b1.M.Y) * (nearestY - b1.M.Y)); //en yakın mesafeyi hesaplama

            if(distance<b1.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kuresilindirCarp(kure a1,silindir b1)
        {
            

            double dx = Math.Abs(a1.M.X - b1.M.X);     
            double dy = Math.Abs(a1.M.Y - b1.M.Y);
            double dz = Math.Abs(a1.M.Z - b1.M.Z);

            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz); //aralarındaki uzaklık

            if (distance > b1.R + a1.R || dz > b1.H / 2 +a1.R)
            {
                return false; // Küre silindirin içinde değil, çarpışma olmayacak
            }

            double distanceXZ = Math.Sqrt(dx * dx + dz * dz); //silindirin yan yuzeylerini kontrol ediyoruz
            if (distanceXZ > b1.R + a1.R)
            {
                return false; // Küre silindirin yanında, ancak çarpışma olmayacak
            }
            else if (dy > b1.H / 2 + a1.R)
            {
                return false; // Küre silindirin yanında, ancak çarpışma olmayacak
            }
            else if (distanceXZ <= b1.R)
            {
                return true; // Küre silindirin yan yüzeyine çarptı
            }
            else if (Math.Abs(dy - b1.H / 2) <= a1.R)
            {
                return true; // Küre silindirin tavanına çarptı
            }
            else if (Math.Abs(dy + b1.H / 2) <= a1.R)
            {
                return true;// Küre silindirin tabanına çarptı
            }
            else
            {
                return false;  // Küre silindirin yanında, ancak çarpışma olmayacak
            }
        }

        public static bool noktadortgenCarp(point a1, dortgen b1)
        {
            //bool isInside = pointX >= rectangleX && pointX <= rectangleX + width && pointY >= rectangleY && pointY <= rectangleY + height;

            bool isInside = a1.X >= b1.M.X && a1.X <= b1.M.X + b1.Genislik && a1.Y >= b1.M.Y && a1.Y <= b1.M.Y + b1.Yukseklik;

            if(isInside)
            {
                return true; //nokta dortgenin icinde
            }
            else
            {
                return false; //nokta dortgenin disinda
            }
        }
        public static bool noktadikdortgenpCarp(dikdortgenprizma a1,point b1)
        {
          

            // Prizmanın sınırlarını hesaplayalım
            double prizma_left = a1.M.X - a1.Uzunluk / 2;
            double prizma_right = a1.M.X + a1.Uzunluk / 2;
            double prizma_bottom = a1.M.Y - a1.Genislik / 2;
            double prizma_top = a1.M.Y + a1.Genislik / 2;
            double prizma_front = a1.M.Z - a1.Yukseklik / 2;
            double prizma_back = a1.M.Z + a1.Yukseklik / 2;

            if (b1.X >= prizma_left && b1.X <= prizma_right &&
            b1.Y >= prizma_bottom && b1.Y <= prizma_top &&
            b1.Z >= prizma_front && b1.Z <= prizma_back)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool dikdortgenpdikdortgenpCarp(dikdortgenprizma a1,dikdortgenprizma b1)
        {
            // İki prizmanın x, y ve z sınırlarını hesaplayın
            float xMin1 = a1.M.X - a1.Genislik / 2;
            float xMax1 = a1.M.X + a1.Genislik / 2;
            float yMin1 = a1.M.Y -a1.Yukseklik / 2;
            float yMax1 = a1.M.Y + a1.Yukseklik / 2;
            float zMin1 = a1.M.Z - a1.Uzunluk / 2;
            float zMax1 = a1.M.Z + a1.Uzunluk/ 2;

            float xMin2 =b1.M.X - b1.Genislik / 2;
            float xMax2 =b1.M.X + b1.Genislik / 2;
            float yMin2 = b1.M.Y - b1.Yukseklik / 2;
            float yMax2 = b1.M.Y +b1.Yukseklik / 2;
            float zMin2 = b1.M.Z - b1.Uzunluk / 2;
            float zMax2 = b1.M.Z + b1.Uzunluk / 2;

            if (xMax1 >= xMin2 && xMin1 <= xMax2 &&   //eger sinirlar kesisiyorsa carpismaktadırlar
        yMax1 >= yMin2 && yMin1 <= yMax2 &&
        zMax1 >= zMin2 && zMin1 <= zMax2)
            {
                return true;
            }

            return false;
        }

        public static bool kuredikdortgenpCarp(kure a1,dikdortgenprizma b1)
        {

            //  prizmanın x, y ve z sınırlarını hesaplayın

            // Kürenin merkez noktasının dikdörtgen prizmanın sınırları içinde olup olmadığını kontrol edin
            float xMin2 = b1.M.X - b1.Genislik / 2;
            float xMax2 = b1.M.X + b1.Genislik / 2;
            float yMin2 = b1.M.Y - b1.Yukseklik / 2;
            float yMax2 = b1.M.Y + b1.Yukseklik / 2;
            float zMin2 = b1.M.Z - b1.Uzunluk / 2;
            float zMax2 = b1.M.Z + b1.Uzunluk / 2;

            bool sphereInsideRectPrism = (a1.M.X >=xMin2 && a1.M.X <=xMax2) &&
                                     (a1.M.Y >= yMin2 && a1.M.Y <= yMax2) &&
                                     (a1.M.Z >=zMin2 &&a1.M.Z <= zMax2);


           
           



            
            // Kürenin merkezi dikdörtgen prizmanın sınırları içinde değilse, çarpışma yok demektir
            if (sphereInsideRectPrism)
            {
                return true;
            }
            else
            {
                return false;
            }
            


        }
        public static bool yuzeykureCarp(yuzey a1,kure b1)
        {

            // Kürenin merkez noktasının yüzeyin sınırları içinde olup olmadığını kontrol ediyoruz
            bool sphereInsideSurface = b1.M.X >= a1.M.X && b1.M.X <= a1.M.X + a1.Uzunluk
                                       && b1.M.Y >= a1.M.Y && b1.M.Y <= a1.M.Y + a1.Yukseklik
                                       && b1.M.Z >= a1.M.Z && b1.M.Z <= a1.M.Z + a1.Uzunluk;

            // Kürenin merkez noktası yüzeyin içinde ise çarpışma var demektir
            if (sphereInsideSurface)
            {
                return true;
            }
            else
            {
                return false;
            }



           
        }
        public static bool yuzeydikdortgenpCarp(dikdortgenprizma a1, yuzey b1)
        {
            // yüzey ve dikdörtgen prizma arasındaki mesafe
            float distanceX = Math.Abs(b1.M.X - a1.M.X) / 2f - a1.Genislik / 2f;
            float distanceY = Math.Abs(b1.M.Y - a1.M.Y) - b1.Yukseklik / 2f - a1.Yukseklik / 2f;
            float distanceZ = Math.Abs(b1.M.Z - a1.M.Z) - b1.Uzunluk / 2f;

            // carpisma denetimi
            if (distanceX < 0 && distanceY < 0 && distanceZ < 0)
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }
        public static bool yuzeysilindirCarp(yuzey a1,silindir b1)
        {
            // Silindirin yüksekliği boyunca hareket ederken yüzeyin içinde olup olmadığını kontrol ediyoruz
            for (float y = 0; y <= b1.M.Y; y += 0.1f)
            {
                // Silindirin merkez noktasını hesaplayalım
                float silindirCenterX =b1.M.X / 2;
                float silindirCenterY = y;
                float silindirCenterZ = b1.M.Z / 2;

                // Silindirin merkez noktası ile yüzeyin merkez noktası arasındaki mesafeyi hesaplayalım
                float distanceX = Math.Abs(silindirCenterX - a1.M.X / 2);
                float distanceY = Math.Abs(silindirCenterY - a1.M.Y / 2);
                float distanceZ = Math.Abs(silindirCenterZ - a1.M.Z / 2);
                float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);

                // Eğer mesafe silindirin yarıçapından küçükse, çarpışma meydana gelmiştir
                if (distance <= b1.R)
                {

                    return true;
                }
            }

            return false;



        }

    }

    }


