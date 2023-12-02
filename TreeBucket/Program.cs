using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeBucket
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllText(@"C:\Users\Mark\source\repos\TreeBucket\TreeBucket\input.txt");
            //var calibrations = input
            //    .TrimEnd()
            //    .Split('\n')
            //    .
            //    .ToList();

            string[] strings = input.Split('\n');
            string[] RefinementNumberOne = new String[strings.Length];
            int[] RefinementNumberTwo = new int[strings.Length];
            int sum = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (Char.IsDigit(strings[i][j]))
                    {
                        RefinementNumberOne[i] += (strings[i][j]);
                        //Console.WriteLine(RefinementNumberOne[i]);
                    }
                }
            }
            for (int i = 0; i < RefinementNumberOne.Length; i++)
            {
                if (RefinementNumberOne[i].Length > 0)
                {
                    if (RefinementNumberOne[i].Length > 2)
                    {
                        string temp = "";
                        temp += RefinementNumberOne[i][0];
                        temp += RefinementNumberOne[i][RefinementNumberOne[i].Length - 1];
                        //Console.WriteLine(temp);
                        RefinementNumberOne[i] = temp;
                    }
                    if (RefinementNumberOne[i].Length < 2)
                    {
                        string temp = "";
                        temp += RefinementNumberOne[i][0];
                        temp += RefinementNumberOne[i][0];
                        //Console.WriteLine(temp);
                        RefinementNumberOne[i] = temp;
                    }
                }

                RefinementNumberTwo[i] = Int32.Parse(RefinementNumberOne[i]);

                Console.WriteLine(RefinementNumberTwo[i]);
            }

            for ( int i = 0;i < RefinementNumberTwo.Length; i++)
            {
                sum += RefinementNumberTwo[i];
                Console.WriteLine($"{i} {sum}");
            }
            Console.WriteLine(sum);
        }
    }
}
