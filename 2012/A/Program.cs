using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeJam_ProblemA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            //3
            //ejp mysljylc kd kxveddknmc re jsicpdrysi
            //rbcpc ypc rtcsra dkh wyfrepkym veddknkmkrkcd
            //de kr kd eoya kw aej tysr re ujdr lkgc jv


            //Output
            //Case #1: our language is impossible to understand
            //Case #2: there are twenty six factorial possibilities
            //Case #3: so it is okay if you want to just give up
            Dictionary<char, char> replaces = new Dictionary<char, char>()
            {
                { 'a', 'y' },
                { 'b', 'h' },
                { 'c', 'e' },
                { 'd', 's' },
                { 'e', 'o' },
                { 'g', 'v' },
                { 'j', 'u' },
                { 'p', 'r' },
                { 'm', 'l' },
                { 'y', 'a' },
                { 's', 'n' },
                { 'l', 'g' },
                { 'z', 'q' },
                { 'o', 'k'},
                { 'k', 'i' },
                
                { 'x', 'm' },
                { 'v', 'p' },
                { 'n', 'b' },
                { 'r', 't' },
                { 'i', 'd' },
                { 'u', 'j' },
                { 't', 'w' },
                { 'h', 'x' },
                { 'w', 'f' },
                { 'f', 'c' },
                { 'q', 'z' },
                { ' ', ' ' }
            };

            var lines = File.ReadAllLines("A-small-attempt0.in");
            var total = int.Parse(lines[0]);
            string[] tofile = new string[total];

            for (int i = 1; i <= total; i++)
            {
                var from = lines[i].ToCharArray();
                StringBuilder to = new StringBuilder();
                var totalline = from.Length;
                for (int j = 0; j < totalline; j++)
                {
                    to.Append(replaces[from[j]]);
                }

                tofile[i-1] = to.ToString();
            }
            File.WriteAllLines("A-small-attempt.out", tofile);
        }
    }
}

