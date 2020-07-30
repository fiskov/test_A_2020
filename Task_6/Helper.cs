using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    static class Helper
    {
        const string prefix = "** ";

        internal static IEnumerable<List<int>> SortTowers(List<List<int>> towers)
        {
            var towersSort = new List<List<int>>();
            foreach (var t in towers)
                towersSort.Add(new List<int>(t));

            towersSort.Sort(
                delegate (List<int> p1, List<int> p2) 
                {
                    return p1.ValuePower().CompareTo(p2.ValuePower());
                }
            );

            foreach (var t in towersSort)
                yield return t;
        }


        public static void AddPower(this List<int> lst, int Power)
        {
            if (lst.Count < 9)
                lst.Add(Power);
            else throw new Exception("Длина башни не должна превышать 9");
        }

        public static void AddTower(this List<List<int>> lst, List<int> Tower)
        {
            if (Tower.Count == 0) return;
            
            foreach (var t in lst)
                if (t.Count == Tower.Count)
                {
                    bool b = true;
                    for (int i = 0; i < t.Count; i++)
                        if (Tower[i] != t[i]) b = false;

                    if (b) throw new Exception("В списке уже есть такая башня"+Environment.NewLine+
                                Tower.ToStringPowers()+ Environment.NewLine +
                                t.ToStringPowers());
                }                                      

            lst.Add(Tower);
        }

        public static void GeneratePowers(this List<int> lst)
        {
            lst.Clear();
            Random r = new Random();
            int cnt = r.Next(2, 9);
            for (int i = 0; i < cnt; i++) lst.Add(r.Next(1, 99));
        }

        public static string ToStringPowers(this List<int> lst)
        {
            StringBuilder s = new StringBuilder();

            foreach (var t in lst)
                s.Append((s.Length != 0 ? prefix : "") + t);

            return s.ToString();
        }

        public static double ValuePower(this List<int> lst)
        {
            double res = 1;
            foreach (var t in lst)
                if (t>1) res *= Math.Log10(t);

            return 1/res;
        }
    }
}
