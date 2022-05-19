﻿using System;
using HW2.Task2;

namespace HW2
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[5, 7];
            MatrixFiller.FillMatrix(ref matrix, "v");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1) - 1; j++)
                {
                    Console.Write($"{matr[i,j], 3:D0},");
                }
                Console.WriteLine($"{matr[i,matr.GetLength(1)-1], 3:D0}");
            }
        }
    }
}