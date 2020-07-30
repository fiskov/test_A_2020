using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    struct cellStruct
    {
        public cellStruct(int _x, int _y, int _v)
        {
            x = _x;
            y = _y;
            value = _v;
        }
        public int x, y, value;
    }

    class MazeData
    {
        public int fieldSize;
        public List<cellStruct> cellsList;

        public MazeData(int size)
        {
            fieldSize = size;
            cellsList = new List<cellStruct>();
        }        
    }

    class Helper
    {
        private const int scale = 15;
        private const int sizeMax = 40;
        private static int fieldSize = 15;

        internal static Size GetFieldSizePixel()
        {
            return new Size(scale * (fieldSize + 2), scale * (fieldSize + 2));
        }

        //0 - проход, 1 - стена, 2 - вход, 3 - выход
        private static int[,] field = new int[sizeMax + 1, sizeMax + 1]; //будет массив с 1 до N, не с 0

        public static Point pStart;
        public static Point pEnd;
        private static Bitmap bmp = new Bitmap((sizeMax + 2) * scale, (sizeMax + 2) * scale);

        internal static void StartPointUpdate(Point point)
        {
            field[pStart.X, pStart.Y] = 0;
            pStart = point;
            field[point.X, point.Y] = 2;
        }

        internal static void EndPointUpdate(Point point)
        {
            field[pEnd.X, pEnd.Y] = 0;
            pEnd = point;
            field[point.X, point.Y] = 3;
        }

        public static DialogResult ShowInputDialog(string title, ref string input)
        {
            Size size = new Size(400, 70);
            Form inputBox = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = size,
                Text = title
            };

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            Button btnOk = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "btnOk",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(btnOk);

            Button btnCancel = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "btnCancel",
                Size = new Size(75, 23),
                Text = "&Отмена",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(btnCancel);

            inputBox.AcceptButton = btnOk;
            inputBox.CancelButton = btnCancel;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        internal static void GenerateMaze()
        {
            int cnt = (fieldSize * fieldSize) / 8;
            Random r = new Random();

            for (int i = 0; i < cnt; i++)
            {
                int x = r.Next(1, fieldSize+1);
                int y = r.Next(1, fieldSize+1);
                Point p = new Point(x, y);
                if (p != pStart && p != pEnd) CellToggle(p);
            }                
        }

        /// <summary>
        /// Меняет значение с "0" на "1" и наоборот.
        /// </summary>
        internal static void Toggle(ref int number)
        {
            if (number < 1 || number > 3) number = 1; else number = 0;
        }

        internal static void CellToggle(Point point)
        {
            Toggle(ref field[point.X, point.Y]);
        }

        internal static void ResetField(int width, bool putStartEndPoints = true)
        {
            fieldSize = width;

            for (int i = 0; i < fieldSize + 1; i++)
                for (int j = 0; j < fieldSize + 1; j++)
                    field[i, j] = 0;

            pStart = new Point(1, 1);
            pEnd = new Point(fieldSize, fieldSize);

            if (putStartEndPoints)
            {
                field[pStart.X, pStart.Y] = 2;
                field[pEnd.X, pEnd.Y] = 3;
            }
        }

        /// <summary>
        /// Проверяет не попадает ли новая точка на существующие координаты
        /// </summary>
        public static bool GetPoint(Point location, out Point res)
        {
            int x = location.X / scale;
            int y = location.Y / scale;

            res = new Point(x, y);
            //если вне диапазона
            if (x < 1 || x > fieldSize || y < 1 || y > fieldSize)
                return false;

            //если на существующую точку
            if (res == pStart || res == pEnd)
                return false;

            return true;
        }
        internal static bool checkBorder(int x, int y) => (x > 0 && x <= fieldSize && y > 0 && y <= fieldSize);

        /// <summary>
        /// Ипользуя волновой алгоритм ищет минимальное число шагов. Если решения нет, возвращает 0.
        /// </summary>
        internal static int GetSteps()
        {
            int stepCount = 0;

            if (pStart.X == 0 || pEnd.X == 0) return 0;
            if (pStart == pEnd) return 0;

            //направления куда можно походить 
            int[,] step = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

            //наличие пустых клеток, на которые можно сделать ход
            bool stepOk;

            //подготовка поля к обходу
            for (int i = 1; i < fieldSize + 1; i++)
                for (int j = 1; j < fieldSize + 1; j++)
                {
                    int num = field[i, j];
                    field[i, j] = (num > 0 && num < 4 ? num : 0); //оставить только 0, 1, 2, 3
                }

            //обход всех клетки поля, на каждой итерации нумерует все возможные ходы из текущей клетки
            do
            {
                stepOk = false;
                for (int i = 1; i < fieldSize + 1; i++)
                    for (int j = 1; j < fieldSize + 1; j++)
                    {
                        //на нулевом ходе делаем ход из стартовой точки
                        //на других ходах делаем ход из клеток предыдущего хода
                        if ((stepCount == 0 && field[i, j] == 2) ||
                            (stepCount > 0 && field[i, j] == -stepCount))
                        {
                            //попытка ходить из текущей клетки по всем направлениям
                            for (int k = 0; k < 4; k++)
                            {
                                int i_next = i + step[k, 0];
                                int j_next = j + step[k, 1];
                                //проверка доступности следующей клетки
                                if (checkBorder(i_next, j_next))
                                {
                                    //найдена конечная клетка
                                    if (field[i_next, j_next] == 3)
                                    {
                                        //восстанавливаем путь
                                        int i_prev = i;
                                        int j_prev = j;
                                        field[i_prev, j_prev] = 4; //так обозначим путь
                                        for (int p=stepCount; p>0; p--)
                                        {
                                            for (int q=0; q<4; q++)
                                            {
                                                int i_prev_next = i_prev + step[q, 0];
                                                int j_prev_next = j_prev + step[q, 1];
                                                if (checkBorder(i_prev_next, j_prev_next) &&
                                                    (field[i_prev_next, j_prev_next] == -(p - 1)))
                                                {
                                                    field[i_prev_next, j_prev_next] = 4;
                                                    i_prev = i_prev_next;
                                                    j_prev = j_prev_next;
                                                    break; //ищем дальше
                                                }
                                            }                                                
                                        }

                                        return stepCount + 1;
                                    }                                        

                                    //следующая клетка пустая
                                    if (field[i_next, j_next] == 0)
                                    {
                                        stepOk = true; //есть пустая клетка
                                        field[i_next, j_next] = -(stepCount + 1);
                                    }
                                }
                            }
                        }
                    }

                stepCount++;
            } while (stepOk); //в этом ходе не было пустых клеток - закончен обход поля
            //значит решения нет

            return 0;
        }

        /// <summary>
        /// Цвет заливки клетки в зависимости от содержимого
        /// </summary>
        internal static Brush GetBrushColor(int fieldNumber)
        {
            Brush[] b = { Brushes.White, Brushes.Crimson, Brushes.Lime, Brushes.SteelBlue, Brushes.Yellow };
            return b[fieldNumber];
        }

        internal static Rectangle GetRect(int x, int y) => new Rectangle(x * scale, y * scale, scale, scale);

        internal static Bitmap DrawChessField()
        {
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                graph.Clear(Color.White);
                
                Pen pen = new Pen(Brushes.LightGray, 1);

                //клетки таблицы 
                for (int i = 0; i < fieldSize; i++)
                    for (int j = 0; j < fieldSize; j++)
                    {
                        graph.DrawRectangle(pen, GetRect(i + 1, j + 1));
                        if (field[i + 1, j + 1] > 0)
                            graph.FillEllipse(
                                GetBrushColor(field[i + 1, j + 1]),
                                GetRect(i + 1, j + 1));
                    }


                //формат подписи
                Font font = new Font(FontFamily.GenericSansSerif, 10);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                graph.TextRenderingHint = TextRenderingHint.AntiAlias;

                font = new Font(FontFamily.GenericSansSerif, 8);
                graph.DrawString("S", font, Brushes.Black, GetRect(pStart.X, pStart.Y), sf);
                graph.DrawString("E", font, Brushes.Black, GetRect(pEnd.X, pEnd.Y), sf);
            }

            return bmp;
        }

        internal static MazeData GetFieldData()
        {
            var maze = new MazeData(fieldSize);

            for (int i=1; i<fieldSize+1; i++)
                for (int j=1; j<fieldSize+1; j++)
                {
                    var n = field[i, j];
                    if (n > 0 && n < 4)
                        maze.cellsList.Add(new cellStruct(i, j, n));
                }

            return maze;
        }

        internal static void SetFieldData(MazeData maze)
        {
            ResetField(maze.fieldSize, false);

            foreach (var cell in maze.cellsList)
            {
                field[cell.x, cell.y] = cell.value;

                if (cell.value == 2)
                    pStart = new Point(cell.x, cell.y);

                if (cell.value == 3)
                    pEnd = new Point(cell.x, cell.y);
            }
        }
    }
}
