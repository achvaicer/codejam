using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeJam_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("C-small-attempt1.in");
            var totallines = int.Parse(lines[0]);
            var tofile = new string[totallines];

            for (int i = 1; i <= totallines; i++)
            {
                var splitted = lines[i].Split(' ');
                var n = int.Parse(splitted[0]);
                var m = int.Parse(splitted[1]);
                var totalrecicled = 0;
                int mlen = m / 2;
                var list = new List<Tuple<int, int>>();

                for (int j = n; j <= m; j++)
                {
                    if (j < 10)
                        continue;
                    var len = j.ToString().Length;

                    for (int k = 1; k <= len; k++)
                    {
                        int pow = (int)Math.Pow(10.0, (double)k);
                        int left = j / pow;
                        int right = j % pow;

                        int inv = int.Parse(right.ToString() + left.ToString());

                        var one = new Tuple<int, int>(j, inv);
                        var two = new Tuple<int, int>(inv, j);

                        if (j != inv && j >= n && j <= m && inv >= n && inv <= m && !list.Contains(one) && !list.Contains(two))
                        {
                            totalrecicled++;
                            list.Add(one);
                            list.Add(two);
                        }
                    }
                    
                }
                tofile[i - 1] = string.Format("Case #{0}: {1}", i, totalrecicled);
            }
            File.WriteAllLines("C-small-attempt1.out", tofile);
        }
    }
}
