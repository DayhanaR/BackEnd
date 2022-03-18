using System;

namespace CursoDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeQuantity;
            string employeeName;
            int[] employeeAges = new int[9];
            int[,] sudoku = new int[9, 9];
            int number = sudoku.Length;

            //for (int i = 0; i < employeeAges.Length; i++)
            //{
            //    Console.WriteLine("Digite la edad de la posicion {0}");
            //    employeeAges[i] = int.Parse(Console.ReadLine());         
            //}

            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(0); j++)
                {
                    if (i % 2 == 0)
                    {
                        sudoku[i, j] = number;
                    }
                    else
                    {
                        sudoku[i, (sudoku.GetLength(0) - 1) - j] = number;
                    }
                    number--;
                }
            }

            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(0); j++)
                {
                    Console.Write(sudoku[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
