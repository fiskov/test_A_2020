using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    static class Helper
    {
        internal static IEnumerable<List<int>> SortTowers(List<List<int>> towers)
        {
            var towersSort = new List<List<int>>();
            foreach (var t in towers)
                towersSort.Add(new List<int>(t));

            IComparer<List<int>> comparer = new CompareClass();
            towersSort.Sort(comparer);

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

                    if (b) throw new Exception("В списке уже есть такая башня");
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

        public static string ToStringPowers(this List<int> lst, string prefix = "**")
        {
            StringBuilder s = new StringBuilder();

            foreach (var t in lst)
                s.Append((s.Length != 0 ? prefix : "") + t);

            return s.ToString();
        }






        
    }

    public class CompareClass : IComparer<List<int>>
    {
        const double EPS = 0.0000000001;

        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(List<int> x, List<int> y)
        {
            return x.Count.CompareTo(y.Count);
        }
    }
}
