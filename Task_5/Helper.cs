using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task_5
{
    struct StructBeam
    {
        public int x, y, dir;
        public StructBeam(int _x, int _y, int _dir)
        {
            x = _x; y = _y; dir = _dir;
        }
    }

    class Helper
    {
        private static int scale = 20;
        private const int sizeMax = 99;
        private static int fieldWidth = 15, fieldHeight=15;


        internal static int GetFieldProp(int size)
        {
            if (size < 20) return 0;
            if (size < 40) return 1;
            if (size < 60) return 2;
            if (size < 80) return 3;
            return 4;
        }

        private static void SetScaleByFieldSize()
        {
            int[] scales = { 20, 17, 14, 12, 8 };
            scale = scales[Math.Max(GetFieldProp(fieldHeight), GetFieldProp(fieldWidth))];
        }

        internal static Size GetFieldSizePixel()
        {
            SetScaleByFieldSize();
            return new Size(scale * (fieldWidth + 2), scale * (fieldHeight + 2));
        }

        //0 - проход, 1 - стена, 2 - светофор
        private static int[,] field = new int[sizeMax + 2, sizeMax + 2]; //будет массив с 1 до N, не с 0

        public static Point pStart;
        private static Bitmap bmp = new Bitmap((sizeMax + 2) * scale, (sizeMax + 2) * scale);

        internal static void StartPointUpdate(Point point)
        {
            field[pStart.X, pStart.Y] = 0;
            pStart = point;
            field[point.X, point.Y] = 2;
        }

        internal static void GenerateMaze()
        {            
            Random r = new Random();
            int cnt = r.Next(1+(fieldWidth * fieldHeight) / 32, 1+(fieldWidth * fieldHeight) / 16);
            bool dir = false; //горизонтальное направление

            for (int i = 0; i < cnt; i++)
            {
                int x = r.Next(1, fieldWidth + 1);
                int y = r.Next(1, fieldHeight + 1);
                for (int j=0; j<r.Next(1,5); j++)
                {
                    int kx = dir ? 1 : 0;
                    int ky = dir ? 0 : 1;

                    Point p = new Point(x + kx * j, y + ky * j);
                    if (p != pStart) CellToggle(p);
                }
                dir = !dir;
            }                
        }

        /// <summary>
        /// Меняет значение с "0" на "1" и наоборот.
        /// </summary>
        internal static void Toggle(ref int number)
        {
            switch (number)
            {
                case 0: number = 1; break;
                case 1: number = 0; break;
                default: break;
            }
        }

        internal static void CellToggle(Point point)
        {
            if (point.X > 0 && point.X <= fieldWidth && point.Y > 0 && point.Y <= fieldHeight) 
                Toggle(ref field[point.X, point.Y]);
        }

        internal static void ResetField(int width, int height)
        {
            fieldWidth = width;
            fieldHeight = height;

            for (int i = 0; i < fieldWidth + 2; i++)
                for (int j = 0; j < fieldHeight + 2; j++)
                    field[i, j] = 0;

            for (int i = 0; i < fieldWidth + 2; i++)
            {
                field[i, 0] = 1;
                field[i, fieldHeight+1] = 1;
            }
            for (int i = 0; i < fieldHeight + 2; i++)
            {
                field[0, i] = 1;
                field[fieldWidth+1, i] = 1;
            }

            pStart = new Point(width / 2 + 1, height / 2 + 1);
            field[pStart.X, pStart.Y] = 2;
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
            if (x < 1 || x > fieldWidth || y < 1 || y > fieldHeight)
                return false;

            //если не на существующую точку
            return (res != pStart);
        }

        /* "номер" направления  - на экране ось Y сверху внизу!
         *      2\   /1
         *         X
         *      3/   \0
         */
        //направления куда можно походить 
        private static int NoramlDir(int dir)
        {
            if (dir < 0) return dir + 4; 
            if (dir > 3) return dir % 4; 
            return dir;
        }
        internal static Point GetStep(int _dir)
        {
            int[,] step = { { 1, 1 }, { 1, -1 }, { -1, -1 }, { -1, 1 } };
            int dir = NoramlDir(_dir);
            
            return new Point(step[dir, 0], step[dir, 1]);
        }
        /// <summary>
        /// Прямой проход по всему лучу
        /// </summary>
        /// <returns>Список с ячейко-лучами</returns>
        internal static List<StructBeam> GetBeam(int x, int y, int _dir)
        {
            List<StructBeam> beams = new List<StructBeam>();

            bool bWork = true;
            int cnt = 0;
            int dir = _dir;

            x += GetStep(dir).X;
            y += GetStep(dir).Y;
            //тут уже стена
            if (field[x, y] > 0) return beams;

            while (bWork) {
                dir = NoramlDir(dir);
                StructBeam beam = new StructBeam(x, y, dir);

                int dx = GetStep(beam.dir).X;
                int dy = GetStep(beam.dir).Y;

                beams.Add(beam);

                switch (GetWallsConfig(beam))
                {
                    case 0:
                    case 1:
                    case 4: 
                        x += dx;
                        y += dy;
                        break;
                    case 3:
                        if (dir == 1 || dir == 3) 
                            y += dy; 
                        else
                            x += dx;

                        dir++; //поворот вправо
                        break;
                    case 6:
                        if (dir == 1 || dir == 3) 
                            x += dx;  
                        else
                            y += dy;

                        dir--; //поворот влево
                        break;
                    default: //варианты 2, 5, 7
                        bWork = false; //дальше нет хода
                        break;
                }
                cnt++;
                if (x <= 0 || y <= 0 || x > fieldWidth || y > fieldHeight || cnt>(fieldHeight*fieldWidth)) 
                    bWork = false;
            }

            return beams;
        }
        /// <summary>
        /// смотрим конфигурацию стен, чтобы определить - куда поворачивать луч
        /// битовая конфигурация, всего 8 вариантов
        ///  \ 4
        ///  1 2
        ///     
        /// </summary>
        public static int GetWallsConfig(StructBeam beam)
        {
            int res = 0;
            int dx = GetStep(beam.dir).X;
            int dy = GetStep(beam.dir).Y;
            if (field[beam.x + 0, beam.y + dy] > 0) res += (beam.dir==1 || beam.dir==3) ? 4 : 1;
            if (field[beam.x + dx, beam.y + dy] > 0) res += 2;
            if (field[beam.x + dx, beam.y + 0] > 0) res += (beam.dir == 1 || beam.dir == 3) ? 1 : 4;

            return res;
        }

        /// <summary>
        /// Цвет заливки клетки в зависимости от содержимого
        /// </summary>
        internal static Brush GetBrushColor(int fieldNumber)
        {
            Brush[] b = { Brushes.White, Brushes.Silver, Brushes.Black };
            return b[fieldNumber];
        }

        internal static Rectangle GetRect(int x, int y) => new Rectangle(x * scale, y * scale, scale, scale);

        internal static void DrawBeam (Graphics graph, List<StructBeam> beams, Color color, int off)
        {
            Pen pen = new Pen(color, (float)2);
            pen.EndCap = LineCap.ArrowAnchor;
            //направление стрелки
            int[,] a = { { 0, 0, 1, 1 }, { 0, 1, 1, 0 }, { 1, 1, 0, 0 }, { 1, 0, 0, 1 } };

            foreach (var beam in beams)
                graph.DrawLine(pen, 
                    (beam.x + a[beam.dir, 0]) * scale + off,
                    (beam.y + a[beam.dir, 1]) * scale + 0,
                    (beam.x + a[beam.dir, 2]) * scale + off,
                    (beam.y + a[beam.dir, 3]) * scale + 0);
        }

        internal static Bitmap DrawField(bool Ligths)
        {
            SetScaleByFieldSize();
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                graph.Clear(Color.White);

                Pen pen = new Pen(Brushes.Gray, 1);

                //клетки лабиринта 
                for (int i = 0; i < fieldWidth + 2; i++)
                    for (int j = 0; j < fieldHeight + 2; j++)
                    {
                        
                        int num = field[i, j];
                        if (num > 0)
                        {
                            graph.FillRectangle(GetBrushColor(num), GetRect(i, j));
                            graph.DrawRectangle(pen, GetRect(i, j));
                        }                            
                    }
                //лучи
                graph.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                if (Ligths)
                {
                    DrawBeam(graph, GetBeam(pStart.X, pStart.Y, 0), Color.Green, 1);
                    DrawBeam(graph, GetBeam(pStart.X, pStart.Y, 1), Color.Gold, 1);
                    DrawBeam(graph, GetBeam(pStart.X, pStart.Y, 2), Color.Red, -1);
                    DrawBeam(graph, GetBeam(pStart.X, pStart.Y, 3), Color.Blue, -1);
                }
            }

            return bmp;
        }


    }
}
