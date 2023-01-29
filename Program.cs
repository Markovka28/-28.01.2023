/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4*/

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 4, y = 4;
        int[,] matrix = new int[x, y];
        int rows = 0, colm = 0, R = 1, L = 0, index = 0, element = y;
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[colm, rows] = i + 1;
            if (--element == 0)
            {
                element = y * (index % 2) + x * ((index + 1) % 2) - (index / 2 - 1) - 2;
                int temp = R;
                R = -L;
                L = temp;
                index++;
            }
            colm += R;
            rows += L;
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}