using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(112, "Jay");
            //dic.Add(115, "Om");
            //dic.Add(132, "Aum");
            //foreach (KeyValuePair<int, string> item in dic)
            //{
            //    Console.WriteLine($" key: {item.Key}, Value:{item.Value}");
            //}
            //int[] array = { 10, 20, 30, 65, 50, 45 };
            ////array.GetLength();

            //List<int> list = array.ToList();
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int[][,] arr2 = new int[3][,] { new int[, ] {{1, 3}, {5, 7}},
            //                                new int[, ] {{0, 2}, {4, 6}, {8, 10}},
            //                                new int[, ] {{11, 22,20}, {99, 88,20}, {10,0, 9},{20, 10, 6 } }};             // Display the array elements:
            //                                            //           for (int q = 0; q < arr2.Length; q++)
            //                                            //           {
            //                                            //               int p = 0;
            //                                            //               for (int r = 0; r < arr2[q].GetLength(p); r++)
            //                                            //               {
            //                                            //                   for (int k = 0; k < arr2[r].Rank; k++)
            //                                            //                       Console.Write(" arr2[" + q + "][" + r + ", " + k + "]:"
            //                                            //                       + arr2[q][r, k] + " ");
            //                                            //                   Console.WriteLine();
            //                                            //               }
            //                                            //               p++;
            //                                            //               Console.WriteLine();
            //                                            //           }
            //int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 6, 8, 9, 6 } };
            //Console.WriteLine(arr2[2].Length);
            public static class A
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }
        }
        public class HelloWorld
        {
            public static void Main()
            {
                int b = A.Sum(5, 4);
                Console.WriteLine(b);
            }
        }
    }
    }
}
