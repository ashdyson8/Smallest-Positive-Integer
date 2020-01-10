﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 13, 1, 10, 34, 1 };
            int n = arr.Length;
            print3largest(arr, n);
        }
        static void print3largest(int[] arr,
                               int arr_size)
        {
            int i, first, second, third;

            
            if (arr_size < 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            third = first = second = 000;
            for (i = 0; i < arr_size; i++)
            {
                if (arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }

                else if (arr[i] > second)
                {
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third)
                    third = arr[i];
            }

            Console.WriteLine("Three largest elements are " +  first + " " + second + " " + third);
        }
    }
}