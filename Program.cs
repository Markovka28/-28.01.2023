/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
двух матриц.*/
using System;

// класс с методами расширения
static class MatrixExt
{
    // получение строк матрицы
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }
    // метод получение столбцов матрицы
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }   
}
class Program
{
    // метод получения матрицы из консоли
    static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Количество строк матрицы {0}:    ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов матрицы {0}: ", name);
        var m = int.Parse(Console.ReadLine());
        var matrix = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                matrix[i, k] = new Random().Next(1, 9);
            }
        }
        return matrix;
    }
    // метод для печати матрицы в консоль
    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
    // метод умножения матриц
    static int[,] MatrixMultiplication(int[,] MatrixI, int[,] MatrixII)
    {       
        if (MatrixI.ColumnsCount() != MatrixII.RowsCount())
        {
            throw new Exception("Количество столбцов матрицы 1 не равно количеству строк матрицы 2, произведение невыполнимо");
        }
        var ResultMatrix = new int[MatrixI.RowsCount(), MatrixII.ColumnsCount()];

        for (var i = 0; i < MatrixI.RowsCount(); i++)
        {
            for (var j = 0; j < MatrixII.ColumnsCount(); j++)
            {
                ResultMatrix[i, j] = 0;

                for (var k = 0; k < MatrixI.ColumnsCount(); k++)
                {
                    ResultMatrix[i, j] += MatrixI[i, k] * MatrixII[k, j];
                }
            }
        }
        return ResultMatrix;
    }
    static void Main(string[] args)
    {    
        Console.WriteLine("Умножение матриц");

        var a = GetMatrixFromConsole("1");
        var b = GetMatrixFromConsole("2");

        Console.WriteLine("Матрица 1:");
        PrintMatrix(a);

        Console.WriteLine("Матрица 2:");
        PrintMatrix(b);

        var result = MatrixMultiplication(a, b);
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(result);
    }
}