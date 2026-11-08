using System;
using System.Collections.Generic;
using System.Text;

namespace cs2_hw
{
    internal class Matrix
    {
        public int[,] arr;
        public Matrix(int rows, int cols)
        {
            arr = new int[rows, cols];
        }
        public void FillRandom()
        {
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-10, 11);
                }
            }
        }
        public Matrix MultiplyByNumber(int num)
        {
            Matrix result = new Matrix(arr.GetLength(0), arr.GetLength(1));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result.arr[i, j] = arr[i, j] * num;
                }
            }
            return result;
        }
        public Matrix Add(Matrix m)
        {
            if (arr.GetLength(0) != m.arr.GetLength(0) || arr.GetLength(1) != m.arr.GetLength(1))
            {
                Console.WriteLine("Matrices must have the same dimensions!");
                return null;
            }
            Matrix result = new Matrix(arr.GetLength(0), arr.GetLength(1));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result.arr[i, j] = arr[i, j] + m.arr[i, j];
                }
            }
            return result;
        }
        public Matrix Multiply(Matrix m)
        {
            if (arr.GetLength(0) != m.arr.GetLength(0) || arr.GetLength(1) != m.arr.GetLength(1))
            {
                Console.WriteLine("Matrixes must have the same dimensions!");
                return null;
            }
            Matrix result = new Matrix(arr.GetLength(0), arr.GetLength(1));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result.arr[i, j] = arr[i, j] * m.arr[i, j];
                }
            }
            return result;
        }
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
