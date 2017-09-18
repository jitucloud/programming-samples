﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //http://www.sanfoundry.com/csharp-program-bubble-sort/
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 5, 4, 1 };
            int t;
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            // 0 , 1, 2, 3
            for (int j = 0; j <= a.Length - 2; j++)
            {
                // 0, 1, 2, 3
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Interation :" + j.ToString() + " " + a[i]);
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
        }
    }
}
