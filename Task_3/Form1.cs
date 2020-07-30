using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        const int scale = 20;
        const int sizeMax = 20;
        int fieldSize = 8;
        //0 - проход, 1 - стена, 2 - вход, 3 - выход
        int[,] field = new int[sizeMax+1, sizeMax+1]; //будет массив с 1 до N, не с 0

        Point pStart;
        Point pEnd;
        string abc = "abcdefghijklmnopqrstuvwxyz";
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            
            bmp = new Bitmap((sizeMax + 2) * scale, (sizeMax + 2) * scale);
            cbSize.SelectedIndex = 5;

            btnChangeSize_Click(null, null);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetPoint(e.Location, pStart, pEnd, out Point point))
            {
                if (e.Button == MouseButtons.Left) {
                    field[pStart.X, pStart.Y] = 0;
                    pStart = point; 
                    field[point.X, point.Y] = 2;  
                }

                if (e.Button == MouseButtons.Right) { 
                    field[pEnd.X, pEnd.Y] = 0;
                    pEnd = point;                    
                    field[point.X, point.Y] = 3;
                }

                if (e.Button == MouseButtons.Middle)
                {
                    Toggle(ref field[point.X, point.Y]);
                    pointOld = point;
                }
                updateField();
            }
        }

        Point pointOld = new Point(0, 0);
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (GetPoint(e.Location, pStart, pEnd, out Point point))
                if (e.Button == MouseButtons.Middle)
                    if (pointOld != point)
                    {
                        Toggle(ref field[point.X, point.Y]);
                        pointOld = point;
                        updateField();
                    }
        }

        private void updateField()
        {
            pictureBox.Image = DrawChessField(bmp, pStart, pEnd, field, fieldSize);
        }

        /// <summary>
        /// Проверяет не попадает ли новая точка на существующие координаты
        /// </summary>
        private bool GetPoint(Point location, Point point1, Point point2, out Point res)
        {
            int x = location.X / scale;
            int y = location.Y / scale;
            
            res = new Point(x, y);
            //если вне диапазона
            if (x < 1 || x > fieldSize || y < 1 || y > fieldSize) 
                return false;

            //если на существующую точку
            if (res == point1 || res == point2)
                return false;

            return true;
        }

        /// <summary>
        /// Конвертация координаты в цифро-буквенную нотацию
        /// </summary>
        private string GetPointLabel(Point point)
        {
            if (point.X > 0)
                return $"{abc[point.X - 1]}{fieldSize + 1 - point.Y}";
            else
                return "XX";
        }

        /// <summary>
        /// Ипользуя обход в ширину ищет минимальное число шагов. Если решения нет, возвращает false.
        /// </summary>
        private int GetSteps(Point pStart, Point pEnd)
        {
            int stepCount = 0;

            if (pStart.X == 0 || pEnd.X == 0) return 0;
            if (pStart == pEnd) return 0;

            //направления куда можно походить Конём
            int[,] step = { { 1, 2 }, { 2, 1 }, { -1, 2 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, 1 }, { -2, -1 } };

            //счетчик пустых клеток, на которые можно сделать ход
            int stepOkCount;

            //подготовка поля к обходу
            for (int i = 1; i < fieldSize + 1; i++)
                for (int j = 1; j < fieldSize + 1; j++)
                    field[i, j] = Math.Max(0, field[i, j]);

            //обход всех клетки поля, на каждой итерации нумерует все возможные ходы из текущей клетки
            do
            {
                stepOkCount = 0;
                for (int i = 1; i < fieldSize + 1; i++)
                    for (int j = 1; j < fieldSize + 1; j++)
                    {
                        //на нулевом ходе делаем ход из стартовой точки
                        //на других ходах делаем ход из клеток предыдущего хода
                        if ((stepCount == 0 && field[i, j] == 2) ||
                            (stepCount > 0 && field[i, j] == -stepCount))
                        {
                            //попытка ходить из текущей клетки по всем направлениям
                            for (int k = 0; k < 8; k++)
                            {
                                int i_next = i + step[k, 0];
                                int j_next = j + step[k, 1];
                                //проверка доступности следующей клетки
                                if (i_next > 0 && i_next <= fieldSize && j_next > 0 && j_next <= fieldSize)
                                {
                                    //возможно дошли до искомой клетки, возвращаем кол-во шагов
                                    if (field[i_next, j_next] == 3)
                                        return stepCount + 1;

                                    //следующая клетка пустая
                                    if (field[i_next, j_next] == 0)
                                    {
                                        stepOkCount++; //счетчик пустых клеток
                                        field[i_next, j_next] = -(stepCount + 1);
                                    }
                                }
                            }
                        }
                    }

                stepCount++;
            } while (stepOkCount > 0); //в этом ходе не было пустых клеток - закончен обход поля

            return 0;
        }

        /// <summary>
        /// Цвет заливки клетки в зависимости от содержимого
        /// </summary>
        private Brush GetBrushColor(int number, int fieldNumber)
        {
            Brush[] b = { Brushes.White, Brushes.Crimson, Brushes.Lime, Brushes.SteelBlue };
            
            if (fieldNumber > 0) return b[fieldNumber];

            if (number > 0) return Brushes.LightGray;

            return Brushes.White;
        }

        private RectangleF GetRect(int x, int y) => new RectangleF(x * scale, y * scale, scale, scale);

        private Bitmap DrawChessField(Bitmap bmp, Point pStart, Point pEnd, int[,] field, int size)
        {
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                graph.Clear(Color.White);

                //клетки шахматной доски 
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        graph.FillRectangle(
                            GetBrushColor((i + j) % 2, field[i + 1, j + 1]),
                            GetRect(i + 1, j + 1));

                //формат подписи
                Font font = new Font(FontFamily.GenericSansSerif, 10);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                graph.TextRenderingHint = TextRenderingHint.AntiAlias;
                
                string s;
                //формат подписи вокруг доски
                for (int i = 0; i < size; i++)
                {
                    s = (fieldSize - i).ToString();
                    graph.DrawString(s, font, Brushes.Black, GetRect(0, i+1), sf);
                    graph.DrawString(s, font, Brushes.Black, GetRect(fieldSize+1, i+1), sf);

                    s = abc[i].ToString();
                    graph.DrawString(s, font, Brushes.Black, GetRect(i + 1, fieldSize + 1), sf);
                    graph.DrawString(s, font, Brushes.Black, GetRect(i + 1, 0), sf);
                }

                font = new Font(FontFamily.GenericSansSerif, 8);
                graph.DrawString("S", font, Brushes.Black, GetRect(pStart.X, pStart.Y), sf);
                graph.DrawString("E", font, Brushes.Black, GetRect(pEnd.X, pEnd.Y), sf);
                
                if (chkShowSteps.Checked == true)
                    for (int i = 0; i < size; i++)
                        for (int j = 0; j < size; j++)
                        {
                            int num = field[i + 1, j + 1];
                            if (num < 0) s = (-num).ToString();
                            else s = "";

                            graph.DrawString(s, font, Brushes.Black, GetRect(i + 1, j + 1), sf);
                        }                            
            }

            return bmp;
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            fieldSize = cbSize.SelectedIndex + 3; //значения в списке начинаются с 3x3

            for (int i = 0; i < fieldSize+1; i++)
                for (int j = 0; j < fieldSize+1; j++)
                    field[i, j] = 0;

            pStart = new Point(1, 1);
            pEnd = new Point(fieldSize, fieldSize);

            field[pStart.X, pStart.Y] = 2;
            field[pEnd.X, pEnd.Y] = 3;

            updateField();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int res = GetSteps(pStart, pEnd);
            txtLog.Text += $"{GetPointLabel(pStart)} => {GetPointLabel(pEnd)}   "
                + (res > 0 ? res.ToString() : "NO") + Environment.NewLine;

            updateField();
        }


        /// <summary>
        /// Меняет значение с "0" на "1" и наоборот.
        /// </summary>
        private void Toggle(ref int number)
        {
            if (number < 1) number = 1; else number = 0;
        }
    }
}
