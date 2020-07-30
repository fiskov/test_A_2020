using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aparu_2
{
    public partial class Form1 : Form
    {
        const int scale = 40;
        Point pStart = new Point(1, 1);
        Point pEnd = new Point(8, 8);
        string abc = "abcdefgh";
        Bitmap bmp;
        int sizeMax = 20;

        public Form1()
        {
            InitializeComponent();
            
            bmp = new Bitmap((sizeMax + 2) * scale, (sizeMax + 2) * scale);
            updateField();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point;

            if (GetPoint(e.Location, pStart, pEnd, out point))
            {
                if (e.Button == MouseButtons.Left) pStart = point;
                if (e.Button == MouseButtons.Right) pEnd = point;

                updateField();

                int res = GetSteps(pStart, pEnd);

                txtLog.Text += $"{GetPointLabel(pStart)} => {GetPointLabel(pEnd)}   "
                    + (res > 0 ? res.ToString() : "NO") + Environment.NewLine;
            }
        }

        private void updateField()
        {
            pictureBox1.Image = DrawChessField(bmp, pStart, pEnd, 8);
        }

        private bool GetPoint(Point location, Point point1, Point point2, out Point res)
        {
            int x = location.X / scale;
            int y = location.Y / scale;
            
            res = new Point(x, y);
            //если вне диапазона
            if (x < 1 || x > 8 || y < 1 || y > 8) 
                return false;

            //если на существующую точку
            if (res == point1 || res == point2)
                return false;

            return true;
        }

        private string GetPointLabel(Point point) => $"{abc[point.X - 1]}{9 - point.Y}";

        private int GetSteps(Point pStart, Point pEnd)
        {
            int[,] step = { { 1, 2 }, { 2, 1 }, { -1, 2 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, 1 }, { -2, -1 } };

            if (pStart.X == 0 || pEnd.X == 0)  return 0; 
            if (pStart == pEnd)  return 0;
            //поиск решения за 1 ход
            for (int i = 0; i < 8; i++)
                if ((pStart.X + step[i, 0] == pEnd.X) &&
                    (pStart.Y + step[i, 1] == pEnd.Y))
                    return 1;


            //поиск решения за 2 хода
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if ((pStart.X + step[i, 0] + step[j, 0] == pEnd.X) &&
                        (pStart.Y + step[i, 1] + step[j, 1] == pEnd.Y))
                    return 2;

            return 0;
        }

        private RectangleF GetRect(int x, int y) => new RectangleF(x * scale, y * scale, scale, scale);

        private Bitmap DrawChessField(Bitmap bmp, Point pStart, Point pEnd, int size)
        {
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                graph.Clear(Color.White);

                Brush bTemp = Brushes.White;
                
                //клетки шахматной доски 
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        if ((i + j) % 2 == 1) 
                            bTemp = Brushes.LightGray; 
                        else 
                            bTemp = Brushes.White;

                        //если точка начала/конца есть, то рисуем её
                        if (pStart.X == i + 1 && pStart.Y == j + 1) 
                            bTemp = Brushes.Lime;
                        if (pEnd.X == i + 1 && pEnd.Y == j + 1) 
                            bTemp = Brushes.SteelBlue;

                        graph.FillRectangle(bTemp, GetRect(i + 1, j + 1));
                    }
                                
                //формат подписи
                Font font = new Font(FontFamily.GenericSansSerif, 14);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                graph.TextRenderingHint = TextRenderingHint.AntiAlias;
                String s;

                //подписи вокруг доски
                for (int i = 0; i < size; i++)
                {
                    s = (8 - i).ToString();
                    graph.DrawString(s, font, Brushes.Black, GetRect(0, i + 1), sf);
                    graph.DrawString(s, font, Brushes.Black, GetRect(8 + 1, i + 1), sf);

                    s = abc[i].ToString();
                    graph.DrawString(s, font, Brushes.Black, GetRect(i + 1, 8 + 1), sf);
                    graph.DrawString(s, font, Brushes.Black, GetRect(i + 1, 0), sf);
                }

                graph.DrawString("S", font, Brushes.Black, GetRect(pStart.X, pStart.Y), sf);
                graph.DrawString("E", font, Brushes.Black, GetRect(pEnd.X, pEnd.Y), sf);
            }

            return bmp;
        }
    }
}
