using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeJam_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("B-small-attempt4.in");
            var totallines = int.Parse(lines[0]);
            var tofile = new string[totallines];

            for (int i = 1; i <= totallines; i++)
            {
                var splited = lines[i].Split(' ');
                var totalgooglers = int.Parse(splited[0]) + 3;
                var surprising = int.Parse(splited[1]);
                var bestresult = double.Parse(splited[2]);
                var totalbestresult = 0;
                var totalsurprising = 0;


                for (int j = 3; j < totalgooglers; j++)
                {
                    var totalresult = int.Parse(splited[j]);
                    var division = Math.Ceiling(totalresult / 3.0);

                    if (division >= bestresult)
                        totalbestresult++;
                    else if (surprising > 0 && division > 0.0  && division >= bestresult  && totalsurprising <= surprising)
                        totalsurprising++;
                }

                tofile[i-1] = string.Format("Case #{0}: {1}", i, totalbestresult + totalsurprising);
                Console.WriteLine(tofile[i - 1]);
            }
            File.WriteAllLines("B-small-attempt4.out", tofile);
            Console.ReadLine();
        }
    }
}
