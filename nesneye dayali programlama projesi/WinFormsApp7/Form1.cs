using System;
using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using static WinFormsApp7.Form1;

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





namespace WinFormsApp7

{
    public partial class Form1 : Form
    {
        private MyGenericClass myRectangles;
        private MyGenericClass myPoints;
        private MyGenericClass myCircles;

        public Form1()
        {
            InitializeComponent();
            myRectangles = new MyGenericClass();
            myPoints = new MyGenericClass();
            myCircles = new MyGenericClass();

        }
        public class Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }


            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;

            }
        }
        public class MyGenericClass
        {
            private List<Shape> items;

            public MyGenericClass()
            {
                items = new List<Shape>();
            }

            public void Add(Shape item)
            {
                items.Add(item);
            }

            public void DrawShapes(Graphics g)
            {
                foreach (Shape item in items)
                {
                    item.Draw(g);
                }
            }
        }

        public abstract class Shape
        {
            public abstract void Draw(Graphics g);
        }

        public class Rectangle : Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Height { get; set; }
            public int Width { get; set; }

            public override void Draw(Graphics g)
            {
                g.DrawRectangle(Pens.Black, X, Y, Width, Height);
            }


        }
        public class Nokta : Shape
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override void Draw(Graphics g)
            {
                g.FillEllipse(Brushes.Black, X, Y, 2, 2);
            }
        }

        public class Circle : Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius { get; set; }

            public override void Draw(Graphics g)
            {
                g.DrawEllipse(Pens.Black, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);

                Rectangle rect = new Rectangle() { X = x, Y = y, Width = width, Height = height };
                myRectangles.Add(rect);

                pictureBox1.Invalidate();

            }
            else if (radioButton2.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

                Nokta nokt = new Nokta { X = x, Y = y };
                myPoints.Add(nokt);
                pictureBox1.Invalidate();

            }
            else if (radioButton3.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int r = int.Parse(textBox5.Text);

                Circle circ = new Circle() { X = x, Y = y, Radius = r };
                myCircles.Add(circ);

                pictureBox1.Invalidate();

            }
            else if (radioButton4.Checked)
            {
                Pen pen = new Pen(Color.Black);

                int x = int.Parse(textBox1.Text);    //in
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = int.Parse(textBox8.Text);  //int.Parse(textBox8.Text)

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);


                pictureBox1.Image = bmp;

            }
            else if (radioButton5.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;

            }
            else if (radioButton6.Checked)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int yukseklik = Convert.ToInt32(textBox4.Text);
                int genislik = Convert.ToInt32(textBox3.Text);
                // Graphics nesnesini al
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                // Dörtgenin çizgi rengini ve kalınlığını ayarla
                Pen pen = new Pen(Color.Black, 2);

                // Dörtgeni çiz
                g.DrawRectangle(pen, x, y, genislik, yukseklik);
                pictureBox1.Image = bmp;

            }
            else if (radioButton7.Checked)
            {
                // Silindirin boyutları
                int width = int.Parse(textBox3.Text); ;
                int height = int.Parse(textBox4.Text);
                int x = int.Parse(textBox1.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox2.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth = width;
                int topEllipseHeight = height / 4;
                int topEllipseX = x;
                int topEllipseY = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth = width;
                int bottomEllipseHeight = height / 4;
                int bottomEllipseX = x;
                int bottomEllipseY = y + height - bottomEllipseHeight;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX, topEllipseY, topEllipseWidth, topEllipseHeight);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX, bottomEllipseY, bottomEllipseWidth, bottomEllipseHeight);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX, topEllipseY + topEllipseHeight / 2, bottomEllipseX, bottomEllipseY + bottomEllipseHeight / 2);
                g.DrawLine(Pens.Gray, topEllipseX + topEllipseWidth, topEllipseY + topEllipseHeight / 2, bottomEllipseX + bottomEllipseWidth, bottomEllipseY + bottomEllipseHeight / 2);
                pictureBox1.Image = bmp;



            }
            else if (radioButton8.Checked)
            {
                Pen pen = new Pen(Color.Black);

                int x = int.Parse(textBox1.Text);    //in
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = 0;  //int.Parse(textBox8.Text)

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);

                pictureBox1.Image = bmp;

            }

            if (listBox1.SelectedItems.Contains("cember") && radioButton3.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int r = int.Parse(textBox5.Text);
                Circle circle = new Circle() { X = x, Y = y, Radius = r };
                myCircles.Add(circle);
                pictureBox1.Invalidate();


                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);
                int r1 = int.Parse(textBox12.Text);
                Circle circle2 = new Circle() { X = x1, Y = y1, Radius = r1 };
                myCircles.Add(circle2);
                pictureBox1.Invalidate();



                float uzaklik = (float)Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2));

                if ((r + r1) > uzaklik)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor.");
                }

            }
            if (radioButton1.Checked && listBox1.SelectedItems.Contains("dikdortgen"))
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                Rectangle rectangle = new Rectangle() { X = x, Y = y, Width = width, Height = height };
                myRectangles.Add(rectangle);


                pictureBox1.Invalidate();

                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);
                int width1 = int.Parse(textBox9.Text);
                int height1 = int.Parse(textBox10.Text);
                Rectangle rectangle1 = new Rectangle() { X = x1, Y = y1, Width = width1, Height = height1 };
                myRectangles.Add(rectangle1);

                /*
                 *  int Xa = a1.Nokta.X + a1.En / 2; //orta nokta
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
                */
                pictureBox1.Invalidate();
                int Xa = x + width / 2;
                int Ya = y + height / 2;
                int Xb = x1 + width1 / 2;
                int Yb = y1 + height1 / 2;

                if (Math.Abs(Xa - Xb) < (width / 2 + width1 / 2) && Math.Abs(Ya - Yb) < (height / 2 + height1 / 2))
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }



            }
            if (radioButton2.Checked && listBox1.SelectedItems.Contains("dortgen")) //radioda nokta-listbox dortgen
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Nokta point = new Nokta() { X = x, Y = y };

                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = Convert.ToInt32(textBox6.Text);
                int y1 = Convert.ToInt32(textBox7.Text);
                int yukseklik = Convert.ToInt32(textBox10.Text);
                int genislik = Convert.ToInt32(textBox9.Text);
                // Graphics nesnesini al
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                // Dörtgenin çizgi rengini ve kalınlığını ayarla
                Pen pen = new Pen(Color.Black, 2);

                // Dörtgeni çiz
                g.DrawRectangle(pen, x, y, genislik, yukseklik);

                // Kullanılmayan nesneleri serbest bırak
                pen.Dispose();
                g.Dispose();

                pictureBox1.Image = bmp;  //a1 nokta b1 dortgen

                /*   bool isInside = a1.X >= b1.M.X && a1.X <= b1.M.X + b1.Genislik && a1.Y >= b1.M.Y && a1.Y <= b1.M.Y + b1.Yukseklik;

            if(isInside)
            {
                return true; //nokta dortgenin icinde
            }
            else
            {
                return false; //nokta dortgenin disinda
            }*/
                bool isInside = x >= x1 && x <= x1 + genislik && y >= y1 && y <= y1 + yukseklik;

                if (isInside)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }

            }
            if (radioButton2.Checked && listBox1.SelectedItems.Contains("cember")) //radio nokta listbox cember
            {
                //a1 cember b1 nokta
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Nokta point = new Nokta() { X = x, Y = y };

                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);
                int r1 = int.Parse(textBox12.Text);
                Circle circle = new Circle() { X = x1, Y = y1, Radius = r1 };
                myCircles.Add(circle);
                pictureBox1.Invalidate();

                float uzaklik = (float)Math.Sqrt(Math.Pow(x1 - ((x)), 2) + Math.Pow(y1 - (y), 2));

                if (uzaklik <= r1)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
                /*  //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
           float uzaklik = (float)Math.Sqrt(Math.Pow(a1.M.X - ((b1.X)), 2) + Math.Pow(a1.M.Y - (b1.Y), 2) );
           //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.

           if (uzaklik <= a1.R)
           {
               return true;
           }
           else
           {
               return false;
           } */
            }
            if (radioButton1.Checked && listBox1.SelectedItems.Contains("cember"))   //dikdortgen cember  dikdortgen radiobutton cember listbox
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                Rectangle rectangle = new Rectangle() { X = x, Y = y, Width = width, Height = height };
                myRectangles.Add(rectangle);


                pictureBox1.Invalidate();
                //dikdortgen a1 cember b1
                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);
                int r1 = int.Parse(textBox12.Text);
                Circle circle = new Circle() { X = x1, Y = y1, Radius = r1 };
                myCircles.Add(circle);
                pictureBox1.Invalidate();

                int x2 = x - width / 2;
                int y2 = y - height / 2;

                int x3 = x + width / 2;
                int y3 = y + height / 2;

                int nearestX = Math.Max(x2, Math.Min(x1, x3));
                int nearestY = Math.Max(y2, Math.Min(y1, y3));

                double distance = Math.Sqrt((nearestX - x1) * (nearestX - x1) + (nearestY - y1) * (nearestY - y1));

                if (distance < r1)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor.");
                }
                /*   int x1 = a1.Nokta.X - a1.En / 2; //sol alt x köşe koordinatı
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
            }*/

            }

            if (radioButton2.Checked && listBox1.SelectedItems.Contains("kure"))//nokta kure. nokta radio button kure listbox
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);

                int r = int.Parse(textBox12.Text);
                int genislik = int.Parse(textBox9.Text);
                int yukseklik = int.Parse(textBox10.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;

                //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
                float uzaklik = (float)Math.Sqrt(Math.Pow(x1 - ((x)), 2) + Math.Pow(y1 - (y), 2));
                //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.


                //kure a1 b1 nokta
                if (uzaklik <= r)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpisiyor.");
                }
            }
            if (radioButton2.Checked && listBox1.SelectedItems.Contains("silindir")) //nokta silindir  nokta radiobutton silindir listbox
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                // Silindirin boyutları
                int width = int.Parse(textBox9.Text); ;
                int height = int.Parse(textBox10.Text);
                int x1 = int.Parse(textBox6.Text); //int.Parse(textBox1.Text)
                int y1 = int.Parse(textBox7.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth = width;
                int topEllipseHeight = height / 4;
                int topEllipseX = x1;
                int topEllipseY = y1;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth = width;
                int bottomEllipseHeight = height / 4;
                int bottomEllipseX = x1;
                int bottomEllipseY = y1 + height - bottomEllipseHeight;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX, topEllipseY, topEllipseWidth, topEllipseHeight);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX, bottomEllipseY, bottomEllipseWidth, bottomEllipseHeight);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX, topEllipseY + topEllipseHeight / 2, bottomEllipseX, bottomEllipseY + bottomEllipseHeight / 2);
                g.DrawLine(Pens.Gray, topEllipseX + topEllipseWidth, topEllipseY + topEllipseHeight / 2, bottomEllipseX + bottomEllipseWidth, bottomEllipseY + bottomEllipseHeight / 2);
                pictureBox1.Image = bmp;
                //silindir a1 b1 nokta

                Point3D pa = new Point3D(x1, y1 + height / 2, 0);
                float uzaklik = (float)Math.Sqrt(Math.Pow((pa.X - x), 2) + Math.Pow((pa.Y - y), 2));




                if ((width) >= (int)uzaklik)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
                // {
                //  return true;   

            }


            if (radioButton2.Checked && listBox1.SelectedItems.Contains("dikdortgenp")) //NOKTA DIKDORTGEN PRIZMA nokta radiobutton dp listbox

            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                Pen pen = new Pen(Color.Black);

                int x1 = int.Parse(textBox6.Text);    //in
                int y1 = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                int depth = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height);
                g.DrawLine(pen, x1 + width, y1, x + width, y + height);
                g.DrawLine(pen, x1, y1 + height, x1 + width, y1 + height);

                // Arka yüz
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width + depth, y1 + depth, x1 + width + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + depth, y1 + height + depth, x1 + width + depth, y1 + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth, y1 + depth);
                g.DrawLine(pen, x1 + width, y1, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1, y1 + height, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width, y1 + height, x1 + width + depth, y1 + height + depth);


                pictureBox1.Image = bmp;
                //dikdortgen prizma a1 nokta b1

                // Prizmanın sınırlarını hesaplayalım
                double prizma_left = x1 - height / 2;
                double prizma_right = x1 + height / 2;
                double prizma_bottom = y1 - width / 2;
                double prizma_top = y1 + width / 2;


                if (x >= prizma_left && x <= prizma_right &&
                y >= prizma_bottom && y <= prizma_top)

                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
            }
            if (radioButton4.Checked && listBox1.SelectedItems.Contains("dikdortgenp"))
            {
                Pen pen = new Pen(Color.Black);

                int x = int.Parse(textBox6.Text);    //in
                int y = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                int depth = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);


                pictureBox1.Image = bmp;



                int x1 = int.Parse(textBox6.Text);    //in
                int y1 = int.Parse(textBox7.Text);
                int width1 = int.Parse(textBox9.Text);
                int height1 = int.Parse(textBox10.Text);
                int depth1 = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width1, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height1);
                g.DrawLine(pen, x1 + width1, y1, x + width1, y + height1);
                g.DrawLine(pen, x1, y1 + height1, x1 + width1, y1 + height1);

                // Arka yüz
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + height1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1, y1 + height1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1, y1 + height1, x1 + width1 + depth1, y1 + height1 + depth1);

                // İki prizmanın x, y ve z sınırlarını hesaplayın
                int xMin1 = x - width / 2;
                int xMax1 = x + width / 2;
                int yMin1 = y - height / 2;
                int yMax1 = y + height / 2;


                int xMin2 = x1 - width1 / 2;
                int xMax2 = x1 + width1 / 2;
                int yMin2 = y1 - height1 / 2;
                int yMax2 = y1 + height1 / 2;


                if (xMax1 >= xMin2 && xMin1 <= xMax2 &&
           yMax1 >= yMin2 && yMin1 <= yMax2)

                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }

                pictureBox1.Image = bmp;
            }
            if (radioButton8.Checked && listBox1.SelectedItems.Contains("kure"))  //kure duzey kure lisbox duzey radiobutton
            {
                int x1 = int.Parse(textBox6.Text);  //
                int y1 = int.Parse(textBox7.Text);

                int r = int.Parse(textBox12.Text);
                int genislik = int.Parse(textBox9.Text);
                int yukseklik = int.Parse(textBox10.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;



                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = 0;


                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);
                pictureBox1.Image = bmp;
                //yuzey a1 kure b1


                // Kürenin merkez noktasının yüzeyin sınırları içinde olup olmadığını kontrol ediyoruz
                bool sphereInsideSurface = x1 >= x && x1 <= x + width
                                           && y1 >= y && y1 <= y + height;


                // Kürenin merkez noktası yüzeyin içinde ise çarpışma var demektir
                if (sphereInsideSurface)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }

            }
            if (radioButton5.Checked && listBox1.SelectedItems.Contains("kure")) //kure kure carpismasi
            {
                int x = int.Parse(textBox1.Text);  //
                int y = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;

                int x1 = int.Parse(textBox6.Text);  //
                int y1 = int.Parse(textBox7.Text);

                int r1 = int.Parse(textBox12.Text);
                int genislik1 = int.Parse(textBox9.Text);
                int yukseklik1 = int.Parse(textBox10.Text);

                int centerX1 = genislik / 2;
                int centerY1 = yukseklik / 2;



                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX1 = centerX1;
                int ellipseCenterY1 = centerY1;

                // elipsin boyutları
                int ellipseWidth1 = 60;
                int ellipseHeight1 = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX1 - ellipseWidth1 / 2, ellipseCenterY1 - ellipseHeight1 / 2, ellipseWidth1, ellipseHeight1);

                pictureBox1.Image = bmp;

                float uzaklik = (float)Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2));
                if ((r + r1) > (int)uzaklik)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
            }
            if (radioButton8.Checked && listBox1.SelectedItems.Contains("dikdortgenp")) //yuzey dik prizma yuzey radio button dik prizma listbox
            {

                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = 0;

                Pen pen = new Pen(Color.Black);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);
                pictureBox1.Image = bmp;


                int x1 = int.Parse(textBox6.Text);    //in
                int y1 = int.Parse(textBox7.Text);
                int width1 = int.Parse(textBox9.Text);
                int height1 = int.Parse(textBox10.Text);
                int depth1 = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width1, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1, y1 + height1);
                g.DrawLine(pen, x1, y1 + height1, x1 + width1, y1 + height1);

                // Arka yüz
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + height1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1, y1 + height1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1, y1 + height1, x1 + width1 + depth1, y1 + height1 + depth1);


                pictureBox1.Image = bmp;
                //a1 dp b1 yuzey

                // yüzey ve dikdörtgen prizma arasındaki mesafe
                float distanceX = Math.Abs(x - x1) / 2f - width1 / 2f;
                float distanceY = Math.Abs(y - y1) - height / 2f - height1 / 2f;


                // carpisma denetimi
                if (distanceX < 0 && distanceY < 0)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }


            }

            if (radioButton5.Checked && listBox1.SelectedItems.Contains("dikdortgenp")) //kure dikprizma kure radiobutton listbox dikprizma
            {
                Pen pen = new Pen(Color.Black);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);


                int x1 = int.Parse(textBox6.Text);    //in
                int y1 = int.Parse(textBox7.Text);
                int width1 = int.Parse(textBox9.Text);
                int height1 = int.Parse(textBox10.Text);
                int depth1 = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width1, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1, y1 + height1);
                g.DrawLine(pen, x1, y1 + height1, x1 + width1, y1 + height1);

                // Arka yüz
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + height1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1, y1 + height1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1, y1 + height1, x1 + width1 + depth1, y1 + height1 + depth1);


                pictureBox1.Image = bmp;

                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;



                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;


                //kure a1 dikp b1
                //  prizmanın x, y ve z sınırlarını hesaplayın

                // Kürenin merkez noktasının dikdörtgen prizmanın sınırları içinde olup olmadığını kontrol edin
                float xMin2 = x1 - width1 / 2;
                float xMax2 = x1 + width1 / 2;
                float yMin2 = y1 - height1 / 2;
                float yMax2 = y1 + height1 / 2;


                bool sphereInsideRectPrism = (x >= xMin2 && x <= xMax2) &&
                                         (y >= yMin2 && y <= yMax2);









                // Kürenin merkezi dikdörtgen prizmanın sınırları içinde değilse, çarpışma yok demektir
                if (sphereInsideRectPrism)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }


            }
            if (radioButton7.Checked && listBox1.SelectedItems.Contains("silindir"))
            {
                // Silindirin boyutları
                int width = int.Parse(textBox3.Text); ;
                int height = int.Parse(textBox4.Text);
                int x1 = int.Parse(textBox1.Text); //int.Parse(textBox1.Text)
                int y1 = int.Parse(textBox2.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth = width;
                int topEllipseHeight = height / 4;
                int topEllipseX = x1;
                int topEllipseY = y1;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth = width;
                int bottomEllipseHeight = height / 4;
                int bottomEllipseX = x1;
                int bottomEllipseY = y1 + height - bottomEllipseHeight;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX, topEllipseY, topEllipseWidth, topEllipseHeight);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX, bottomEllipseY, bottomEllipseWidth, bottomEllipseHeight);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX, topEllipseY + topEllipseHeight / 2, bottomEllipseX, bottomEllipseY + bottomEllipseHeight / 2);
                g.DrawLine(Pens.Gray, topEllipseX + topEllipseWidth, topEllipseY + topEllipseHeight / 2, bottomEllipseX + bottomEllipseWidth, bottomEllipseY + bottomEllipseHeight / 2);
                pictureBox1.Image = bmp;
                //silindir a1 b1 nokta

                // Silindirin boyutları
                int width1 = int.Parse(textBox9.Text); ;
                int height1 = int.Parse(textBox10.Text);
                int x = int.Parse(textBox6.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox7.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth1 = width1;
                int topEllipseHeight1 = height1 / 4;
                int topEllipseX1 = x;
                int topEllipseY1 = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth1 = width1;
                int bottomEllipseHeight1 = height1 / 4;
                int bottomEllipseX1 = x;
                int bottomEllipseY1 = y + height1 - bottomEllipseHeight1;


                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX1, topEllipseY1, topEllipseWidth1, topEllipseHeight1);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX1, bottomEllipseY1, bottomEllipseWidth1, bottomEllipseHeight1);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                g.DrawLine(Pens.Gray, topEllipseX1 + topEllipseWidth1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1 + bottomEllipseWidth1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                pictureBox1.Image = bmp;
                //silindir a1 b1 nokta

                Point3D pa = new Point3D(x, y + height1 / 2, 0);
                Point3D pb = new Point3D(x1, y1 + height / 2, 0);

                float uzaklik = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) + Math.Pow((pa.Y - pb.Y), 2));


                if ((width + width1) > (int)uzaklik && Math.Abs(pa.Y - pb.Y) < ((height1 + height) / 2))
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
            }//silindir silindir

            if (radioButton5.Checked && listBox1.SelectedItems.Contains("silindir"))//kure silindir kure radio button silindir listbox1
            {

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Silindirin boyutları
                int width1 = int.Parse(textBox9.Text); ;
                int height1 = int.Parse(textBox10.Text);
                int x = int.Parse(textBox6.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox7.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth1 = width1;
                int topEllipseHeight1 = height1 / 4;
                int topEllipseX1 = x;
                int topEllipseY1 = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth1 = width1;
                int bottomEllipseHeight1 = height1 / 4;
                int bottomEllipseX1 = x;
                int bottomEllipseY1 = y + height1 - bottomEllipseHeight1;


                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX1, topEllipseY1, topEllipseWidth1, topEllipseHeight1);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX1, bottomEllipseY1, bottomEllipseWidth1, bottomEllipseHeight1);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                g.DrawLine(Pens.Gray, topEllipseX1 + topEllipseWidth1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1 + bottomEllipseWidth1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                pictureBox1.Image = bmp;


                Pen pen = new Pen(Color.Black);
                int x1 = int.Parse(textBox1.Text);
                int y1 = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;



                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                pictureBox1.Image = bmp;

                //kure a1 silindir b1

                double dx = Math.Abs(x1 - x);
                double dy = Math.Abs(y1 - y);


                double distance = Math.Sqrt(dx * dx + dy * dy); //aralarındaki uzaklık

                if (distance > r + width1)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin içinde değil, çarpışma olmayacak
                }

                double distanceXZ = Math.Sqrt(dx * dx); //silindirin yan yuzeylerini kontrol ediyoruz
                if (distanceXZ > r + width1)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin yanında, ancak çarpışma olmayacak
                }
                else if (dy > height1 / 2 + r)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin yanında, ancak çarpışma olmayacak
                }
                else if (distanceXZ <= width1)
                {
                    MessageBox.Show("carpisacak"); // Küre silindirin yan yüzeyine çarptı
                }
                else if (Math.Abs(dy - height1 / 2) <= r)
                {
                    MessageBox.Show("carpisacak"); ; // Küre silindirin tavanına çarptı
                }
                else if (Math.Abs(dy + height1 / 2) <= r)
                {
                    MessageBox.Show("carpisacak");// Küre silindirin tabanına çarptı
                }
                else
                {
                    MessageBox.Show("carpismacak");  // Küre silindirin yanında, ancak çarpışma olmayacak
                }

            }
            if (radioButton8.Checked && listBox1.SelectedItems.Contains("silindir"))
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black);
                // Silindirin boyutları
                int width1 = int.Parse(textBox9.Text); ;
                int height1 = int.Parse(textBox10.Text);
                int x = int.Parse(textBox6.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox7.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth1 = width1;
                int topEllipseHeight1 = height1 / 4;
                int topEllipseX1 = x;
                int topEllipseY1 = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth1 = width1;
                int bottomEllipseHeight1 = height1 / 4;
                int bottomEllipseX1 = x;
                int bottomEllipseY1 = y + height1 - bottomEllipseHeight1;


                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX1, topEllipseY1, topEllipseWidth1, topEllipseHeight1);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX1, bottomEllipseY1, bottomEllipseWidth1, bottomEllipseHeight1);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                g.DrawLine(Pens.Gray, topEllipseX1 + topEllipseWidth1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1 + bottomEllipseWidth1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                pictureBox1.Image = bmp;


                int x1 = int.Parse(textBox1.Text);
                int y1 = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = 0;


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height);
                g.DrawLine(pen, x1 + width, y1, x1 + width, y1 + height);
                g.DrawLine(pen, x1, y1 + height, x1 + width, y1 + height);

                // Arka yüz
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width + depth, y1 + depth, x1 + width + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + depth, y1 + height + depth, x1 + width + depth, y1 + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth, y1 + depth);
                g.DrawLine(pen, x1 + width, y1, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1, y1 + height, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width, y1 + height, x1 + width + depth, y1 + height + depth);
                pictureBox1.Image = bmp;

                //yuzey a1 silindir b1

                // Silindirin yüksekliği boyunca hareket ederken yüzeyin içinde olup olmadığını kontrol ediyoruz
                for (float d = 0; y <= d; d += 0.1f)
                {
                    // Silindirin merkez noktasını hesaplayalım
                    float silindirCenterX = x / 2;
                    float silindirCenterY = y;


                    // Silindirin merkez noktası ile yüzeyin merkez noktası arasındaki mesafeyi hesaplayalım
                    float distanceX = Math.Abs(silindirCenterX - x1 / 2);
                    float distanceY = Math.Abs(silindirCenterY - y1 / 2);

                    float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

                    // Eğer mesafe silindirin yarıçapından küçükse, çarpışma meydana gelmiştir
                    if (distance >= width)
                    {

                        MessageBox.Show("carpisiyor");
                    }
                }
                MessageBox.Show("carpismiyor.");


            }
            if (radioButton6.Checked && listBox1.SelectedItems.Contains("nokta")) //radioda listbox nokta- radio dortgen
            {
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                Nokta point = new Nokta() { X = x, Y = y };

                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = Convert.ToInt32(textBox1.Text);
                int y1 = Convert.ToInt32(textBox2.Text);
                int yukseklik = Convert.ToInt32(textBox4.Text);
                int genislik = Convert.ToInt32(textBox3.Text);
                // Graphics nesnesini al
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                // Dörtgenin çizgi rengini ve kalınlığını ayarla
                Pen pen = new Pen(Color.Black, 2);

                // Dörtgeni çiz
                g.DrawRectangle(pen, x, y, genislik, yukseklik);

                // Kullanılmayan nesneleri serbest bırak
                pen.Dispose();
                g.Dispose();

                pictureBox1.Image = bmp;  //a1 nokta b1 dortgen

                /*   bool isInside = a1.X >= b1.M.X && a1.X <= b1.M.X + b1.Genislik && a1.Y >= b1.M.Y && a1.Y <= b1.M.Y + b1.Yukseklik;

            if(isInside)
            {
                return true; //nokta dortgenin icinde
            }
            else
            {
                return false; //nokta dortgenin disinda
            }*/
                bool isInside = x >= x1 && x <= x1 + genislik && y >= y1 && y <= y1 + yukseklik;

                if (isInside)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }

            }
            if (radioButton3.Checked && listBox1.SelectedItems.Contains("nokta")) //radio nokta listbox cember  ---- radio cember listbox nokta
            {
                //a1 cember b1 nokta
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                Nokta point = new Nokta() { X = x, Y = y };

                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = int.Parse(textBox1.Text);
                int y1 = int.Parse(textBox2.Text);
                int r1 = int.Parse(textBox5.Text);
                Circle circle = new Circle() { X = x1, Y = y1, Radius = r1 };
                myCircles.Add(circle);
                pictureBox1.Invalidate();

                float uzaklik = (float)Math.Sqrt(Math.Pow(x1 - ((x)), 2) + Math.Pow(y1 - (y), 2));

                if (uzaklik <= r1)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
                /*  //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
           float uzaklik = (float)Math.Sqrt(Math.Pow(a1.M.X - ((b1.X)), 2) + Math.Pow(a1.M.Y - (b1.Y), 2) );
           //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.

           if (uzaklik <= a1.R)
           {
               return true;
           }
           else
           {
               return false;
           } */
            }
            if (radioButton3.Checked && listBox1.SelectedItems.Contains("dikdortgen"))   //dikdortgen cember  dikdortgen radiobutton cember listbox    ---- cember radiobutton dikdortgen listbox
            {
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                Rectangle rectangle = new Rectangle() { X = x, Y = y, Width = width, Height = height };
                myRectangles.Add(rectangle);


                pictureBox1.Invalidate();
                //dikdortgen a1 cember b1
                int x1 = int.Parse(textBox1.Text);
                int y1 = int.Parse(textBox2.Text);
                int r1 = int.Parse(textBox5.Text);
                Circle circle = new Circle() { X = x1, Y = y1, Radius = r1 };
                myCircles.Add(circle);
                pictureBox1.Invalidate();

                int x2 = x - width / 2;
                int y2 = y - height / 2;

                int x3 = x + width / 2;
                int y3 = y + height / 2;

                int nearestX = Math.Max(x2, Math.Min(x1, x3));
                int nearestY = Math.Max(y2, Math.Min(y1, y3));

                double distance = Math.Sqrt((nearestX - x1) * (nearestX - x1) + (nearestY - y1) * (nearestY - y1));

                if (distance < r1)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpismiyor.");
                }
                /*   int x1 = a1.Nokta.X - a1.En / 2; //sol alt x köşe koordinatı
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
            }*/

            }

            if (radioButton5.Checked && listBox1.SelectedItems.Contains("nokta"))//nokta kure. nokta radio button kure listbox   --nokta listbox kure radiobutton
            {
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                int x1 = int.Parse(textBox1.Text);
                int y1 = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;

                //Uzaklık = √[(x - a)^2 + (y - b)^2 + (z - c)^2]
                float uzaklik = (float)Math.Sqrt(Math.Pow(x1 - ((x)), 2) + Math.Pow(y1 - (y), 2));
                //uzaklık kürenin yarıçapından küçük veya eşitse, küre ve nokta çarpışmış demektir.


                //kure a1 b1 nokta
                if (uzaklik <= r)
                {
                    MessageBox.Show("carpisiyor.");
                }
                else
                {
                    MessageBox.Show("carpisiyor.");
                }
            }
            if (radioButton7.Checked && listBox1.SelectedItems.Contains("nokta")) //nokta silindir  nokta radiobutton silindir listbox  ---- nokta listobx silindir radiobutton
            {
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                // Silindirin boyutları
                int width = int.Parse(textBox3.Text); ;
                int height = int.Parse(textBox4.Text);
                int x1 = int.Parse(textBox1.Text); //int.Parse(textBox1.Text)
                int y1 = int.Parse(textBox2.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth = width;
                int topEllipseHeight = height / 4;
                int topEllipseX = x1;
                int topEllipseY = y1;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth = width;
                int bottomEllipseHeight = height / 4;
                int bottomEllipseX = x1;
                int bottomEllipseY = y1 + height - bottomEllipseHeight;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX, topEllipseY, topEllipseWidth, topEllipseHeight);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX, bottomEllipseY, bottomEllipseWidth, bottomEllipseHeight);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX, topEllipseY + topEllipseHeight / 2, bottomEllipseX, bottomEllipseY + bottomEllipseHeight / 2);
                g.DrawLine(Pens.Gray, topEllipseX + topEllipseWidth, topEllipseY + topEllipseHeight / 2, bottomEllipseX + bottomEllipseWidth, bottomEllipseY + bottomEllipseHeight / 2);
                pictureBox1.Image = bmp;
                //silindir a1 b1 nokta

                Point3D pa = new Point3D(x1, y1 + height / 2, 0);
                float uzaklik = (float)Math.Sqrt(Math.Pow((pa.X - x), 2) + Math.Pow((pa.Y - y), 2));




                if ((width) >= (int)uzaklik)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
                // {
                //  return true;   

            }


            if (radioButton4.Checked && listBox1.SelectedItems.Contains("nokta")) //NOKTA DIKDORTGEN PRIZMA nokta radiobutton dp listbox ----> dp radiobutton nokta listbox

            {
                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                Nokta point = new Nokta() { X = x, Y = y };
                myPoints.Add(point);
                pictureBox1.Invalidate();

                Pen pen = new Pen(Color.Black);

                int x1 = int.Parse(textBox1.Text);    //in
                int y1 = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);
                int depth = int.Parse(textBox11.Text);  //int.Parse(textBox8.Text)

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height);
                g.DrawLine(pen, x1 + width, y1, x + width, y + height);
                g.DrawLine(pen, x1, y1 + height, x1 + width, y1 + height);

                // Arka yüz
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width + depth, y1 + depth, x1 + width + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + depth, y1 + height + depth, x1 + width + depth, y1 + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth, y1 + depth);
                g.DrawLine(pen, x1 + width, y1, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1, y1 + height, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width, y1 + height, x1 + width + depth, y1 + height + depth);


                pictureBox1.Image = bmp;
                //dikdortgen prizma a1 nokta b1

                // Prizmanın sınırlarını hesaplayalım
                double prizma_left = x1 - height / 2;
                double prizma_right = x1 + height / 2;
                double prizma_bottom = y1 - width / 2;
                double prizma_top = y1 + width / 2;


                if (x >= prizma_left && x <= prizma_right &&
                y >= prizma_bottom && y <= prizma_top)

                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
            }

            if (radioButton5.Checked && listBox1.SelectedItems.Contains("duzey"))  //kure duzey kure lisbox duzey radiobutton    ----> duzey listbox kure radiobutton
            {
                int x1 = int.Parse(textBox1.Text);  //
                int y1 = int.Parse(textBox2.Text);

                int r = int.Parse(textBox5.Text);
                int genislik = int.Parse(textBox3.Text);
                int yukseklik = int.Parse(textBox4.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                pictureBox1.Image = bmp;



                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                int depth = 0;


                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);
                pictureBox1.Image = bmp;
                //yuzey a1 kure b1


                // Kürenin merkez noktasının yüzeyin sınırları içinde olup olmadığını kontrol ediyoruz
                bool sphereInsideSurface = x1 >= x && x1 <= x + width
                                           && y1 >= y && y1 <= y + height;


                // Kürenin merkez noktası yüzeyin içinde ise çarpışma var demektir
                if (sphereInsideSurface)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }

            }

            if (radioButton4.Checked && listBox1.SelectedItems.Contains("duzey")) //yuzey dik prizma yuzey radio button dik prizma listbox  ---> yuzey listbox dikp radiobutton
            {

                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                int depth = 0;

                Pen pen = new Pen(Color.Black);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                // Ön yüz
                g.DrawLine(pen, x, y, x + width, y);
                g.DrawLine(pen, x, y, x, y + height);
                g.DrawLine(pen, x + width, y, x + width, y + height);
                g.DrawLine(pen, x, y + height, x + width, y + height);

                // Arka yüz
                g.DrawLine(pen, x + depth, y + depth, x + width + depth, y + depth);
                g.DrawLine(pen, x + depth, y + depth, x + depth, y + height + depth);
                g.DrawLine(pen, x + width + depth, y + depth, x + width + depth, y + height + depth);
                g.DrawLine(pen, x + depth, y + height + depth, x + width + depth, y + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x, y, x + depth, y + depth);
                g.DrawLine(pen, x + width, y, x + width + depth, y + depth);
                g.DrawLine(pen, x, y + height, x + depth, y + height + depth);
                g.DrawLine(pen, x + width, y + height, x + width + depth, y + height + depth);
                pictureBox1.Image = bmp;


                int x1 = int.Parse(textBox1.Text);    //in
                int y1 = int.Parse(textBox2.Text);
                int width1 = int.Parse(textBox3.Text);
                int height1 = int.Parse(textBox4.Text);
                int depth1 = int.Parse(textBox8.Text);  //int.Parse(textBox8.Text)


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width1, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1, y1 + height1);
                g.DrawLine(pen, x1, y1 + height1, x1 + width1, y1 + height1);

                // Arka yüz
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + height1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1, y1 + height1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1, y1 + height1, x1 + width1 + depth1, y1 + height1 + depth1);


                pictureBox1.Image = bmp;
                //a1 dp b1 yuzey

                // yüzey ve dikdörtgen prizma arasındaki mesafe
                float distanceX = Math.Abs(x - x1) / 2f - width1 / 2f;
                float distanceY = Math.Abs(y - y1) - height / 2f - height1 / 2f;


                // carpisma denetimi
                if (distanceX < 0 && distanceY < 0)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }
            }

            if (radioButton4.Checked && listBox1.SelectedItems.Contains("kure")) //kure dikprizma kure radiobutton listbox dikprizma  --->kure listbox dikp radiobutton
            {
                Pen pen = new Pen(Color.Black);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);


                int x1 = int.Parse(textBox1.Text);    //in
                int y1 = int.Parse(textBox2.Text);
                int width1 = int.Parse(textBox3.Text);
                int height1 = int.Parse(textBox4.Text);
                int depth1 = int.Parse(textBox8.Text);  //int.Parse(textBox8.Text)


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width1, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1, y1 + height1);
                g.DrawLine(pen, x1, y1 + height1, x1 + width1, y1 + height1);

                // Arka yüz
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + depth1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1 + depth1, y1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + depth1, y1 + height1 + depth1, x1 + width1 + depth1, y1 + height1 + depth1);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1 + width1, y1, x1 + width1 + depth1, y1 + depth1);
                g.DrawLine(pen, x1, y1 + height1, x1 + depth1, y1 + height1 + depth1);
                g.DrawLine(pen, x1 + width1, y1 + height1, x1 + width1 + depth1, y1 + height1 + depth1);


                pictureBox1.Image = bmp;

                int x = int.Parse(textBox6.Text);
                int y = int.Parse(textBox7.Text);

                int r = int.Parse(textBox12.Text);
                int genislik = int.Parse(textBox9.Text);
                int yukseklik = int.Parse(textBox10.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;



                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);

                pictureBox1.Image = bmp;


                //kure a1 dikp b1
                //  prizmanın x, y ve z sınırlarını hesaplayın

                // Kürenin merkez noktasının dikdörtgen prizmanın sınırları içinde olup olmadığını kontrol edin
                float xMin2 = x1 - width1 / 2;
                float xMax2 = x1 + width1 / 2;
                float yMin2 = y1 - height1 / 2;
                float yMax2 = y1 + height1 / 2;


                bool sphereInsideRectPrism = (x >= xMin2 && x <= xMax2) &&
                                         (y >= yMin2 && y <= yMax2);









                // Kürenin merkezi dikdörtgen prizmanın sınırları içinde değilse, çarpışma yok demektir
                if (sphereInsideRectPrism)
                {
                    MessageBox.Show("carpisiyor");
                }
                else
                {
                    MessageBox.Show("carpismiyor");
                }


            }

            if (radioButton7.Checked && listBox1.SelectedItems.Contains("kure"))//kure silindir kure radio button silindir listbox1   ____> silindir radiobutton kure listbox
            {

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                // Silindirin boyutları
                int width1 = int.Parse(textBox3.Text); ;
                int height1 = int.Parse(textBox4.Text);
                int x = int.Parse(textBox1.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox2.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth1 = width1;
                int topEllipseHeight1 = height1 / 4;
                int topEllipseX1 = x;
                int topEllipseY1 = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth1 = width1;
                int bottomEllipseHeight1 = height1 / 4;
                int bottomEllipseX1 = x;
                int bottomEllipseY1 = y + height1 - bottomEllipseHeight1;


                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX1, topEllipseY1, topEllipseWidth1, topEllipseHeight1);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX1, bottomEllipseY1, bottomEllipseWidth1, bottomEllipseHeight1);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                g.DrawLine(Pens.Gray, topEllipseX1 + topEllipseWidth1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1 + bottomEllipseWidth1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                pictureBox1.Image = bmp;


                Pen pen = new Pen(Color.Black);
                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);

                int r = int.Parse(textBox12.Text);
                int genislik = int.Parse(textBox9.Text);
                int yukseklik = int.Parse(textBox10.Text);

                int centerX = genislik / 2;
                int centerY = yukseklik / 2;



                g.DrawEllipse(pen, centerX - r, centerY - r, 2 * r, 2 * r);

                // elipsin merkezi
                int ellipseCenterX = centerX;
                int ellipseCenterY = centerY;

                // elipsin boyutları
                int ellipseWidth = 60;
                int ellipseHeight = 30;

                // elipsi çizdir
                g.DrawEllipse(pen, ellipseCenterX - ellipseWidth / 2, ellipseCenterY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                pictureBox1.Image = bmp;

                //kure a1 silindir b1

                double dx = Math.Abs(x1 - x);
                double dy = Math.Abs(y1 - y);


                double distance = Math.Sqrt(dx * dx + dy * dy); //aralarındaki uzaklık

                if (distance > r + width1)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin içinde değil, çarpışma olmayacak
                }

                double distanceXZ = Math.Sqrt(dx * dx); //silindirin yan yuzeylerini kontrol ediyoruz
                if (distanceXZ > r + width1)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin yanında, ancak çarpışma olmayacak
                }
                else if (dy > height1 / 2 + r)
                {
                    MessageBox.Show("carpismayacak"); // Küre silindirin yanında, ancak çarpışma olmayacak
                }
                else if (distanceXZ <= width1)
                {
                    MessageBox.Show("carpisacak"); // Küre silindirin yan yüzeyine çarptı
                }
                else if (Math.Abs(dy - height1 / 2) <= r)
                {
                    MessageBox.Show("carpisacak"); ; // Küre silindirin tavanına çarptı
                }
                else if (Math.Abs(dy + height1 / 2) <= r)
                {
                    MessageBox.Show("carpisacak");// Küre silindirin tabanına çarptı
                }
                else
                {
                    MessageBox.Show("carpismacak");  // Küre silindirin yanında, ancak çarpışma olmayacak
                }

            }
            if (radioButton7.Checked && listBox1.SelectedItems.Contains("duzey"))    //duzey silindir-> silindir radiobox duzey listbox
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black);
                // Silindirin boyutları
                int width1 = int.Parse(textBox3.Text); ;
                int height1 = int.Parse(textBox4.Text);
                int x = int.Parse(textBox1.Text); //int.Parse(textBox1.Text)
                int y = int.Parse(textBox2.Text); ;

                // Üst elipsin boyutları ve koordinatları
                int topEllipseWidth1 = width1;
                int topEllipseHeight1 = height1 / 4;
                int topEllipseX1 = x;
                int topEllipseY1 = y;

                // Alt elipsin boyutları ve koordinatları
                int bottomEllipseWidth1 = width1;
                int bottomEllipseHeight1 = height1 / 4;
                int bottomEllipseX1 = x;
                int bottomEllipseY1 = y + height1 - bottomEllipseHeight1;


                // Üst elipsi çiz
                g.FillEllipse(Brushes.Gray, topEllipseX1, topEllipseY1, topEllipseWidth1, topEllipseHeight1);

                // Alt elipsi çiz
                g.FillEllipse(Brushes.Gray, bottomEllipseX1, bottomEllipseY1, bottomEllipseWidth1, bottomEllipseHeight1);

                // Silindirin yan yüzeylerini çiz
                g.DrawLine(Pens.Gray, topEllipseX1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                g.DrawLine(Pens.Gray, topEllipseX1 + topEllipseWidth1, topEllipseY1 + topEllipseHeight1 / 2, bottomEllipseX1 + bottomEllipseWidth1, bottomEllipseY1 + bottomEllipseHeight1 / 2);
                pictureBox1.Image = bmp;


                int x1 = int.Parse(textBox6.Text);
                int y1 = int.Parse(textBox7.Text);
                int width = int.Parse(textBox9.Text);
                int height = int.Parse(textBox10.Text);
                int depth = 0;


                // Ön yüz
                g.DrawLine(pen, x1, y1, x1 + width, y1);
                g.DrawLine(pen, x1, y1, x1, y1 + height);
                g.DrawLine(pen, x1 + width, y1, x1 + width, y1 + height);
                g.DrawLine(pen, x1, y1 + height, x1 + width, y1 + height);

                // Arka yüz
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1 + depth, y1 + depth, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width + depth, y1 + depth, x1 + width + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + depth, y1 + height + depth, x1 + width + depth, y1 + height + depth);

                // Yan yüzler
                g.DrawLine(pen, x1, y1, x1 + depth, y1 + depth);
                g.DrawLine(pen, x1 + width, y1, x1 + width + depth, y1 + depth);
                g.DrawLine(pen, x1, y1 + height, x1 + depth, y1 + height + depth);
                g.DrawLine(pen, x1 + width, y1 + height, x1 + width + depth, y1 + height + depth);
                pictureBox1.Image = bmp;

                //yuzey a1 silindir b1

                // Silindirin yüksekliği boyunca hareket ederken yüzeyin içinde olup olmadığını kontrol ediyoruz
                for (float d = 0; y <= d; d += 0.1f)
                {
                    // Silindirin merkez noktasını hesaplayalım
                    float silindirCenterX = x / 2;
                    float silindirCenterY = y;


                    // Silindirin merkez noktası ile yüzeyin merkez noktası arasındaki mesafeyi hesaplayalım
                    float distanceX = Math.Abs(silindirCenterX - x1 / 2);
                    float distanceY = Math.Abs(silindirCenterY - y1 / 2);

                    float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

                    // Eğer mesafe silindirin yarıçapından küçükse, çarpışma meydana gelmiştir
                    if (distance >= width)
                    {

                        MessageBox.Show("carpisiyor");
                    }
                }
                MessageBox.Show("carpismiyor.");


            }


        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            myRectangles.DrawShapes(e.Graphics);
            myPoints.DrawShapes(e.Graphics);
            myCircles.DrawShapes(e.Graphics);
        }
    }



}







