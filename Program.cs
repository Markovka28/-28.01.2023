/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов > строк: ");
        int colm = int.Parse(Console.ReadLine());
        int[,] mas = new int[rows, colm];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                mas[i, j] = new Random().Next(1, 9);
        }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                Console.Write("{0,5}", mas[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine("_______________________________");
        int index = 0;
        int minsum = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < mas.GetLength(1); j++)
            {
            sum += mas[i, j]; 
            }
            Console.WriteLine($"Сумма {i + 1} строки = {sum}");
            if (i == 0) 
            minsum = sum;
            else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        line += mas[index, j] + " ";
    }
    Console.WriteLine($"В {index+1} строке минимальная сумма элементов.");   
}
}