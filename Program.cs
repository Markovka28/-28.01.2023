/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.*/

int[,] mas = new int[5, 5];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                mas[i, j] = new Random().Next(11, 99);
        }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                Console.Write("{0,5}", mas[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine("       ↑↑↑Неупорядоченный массив↑↑↑");
        Console.WriteLine("↓↓↓Каждая строка упорядочена по убыванию↓↓↓");
        var arr = mas.Cast<int>().OrderByDescending(a => a).ToArray(); //Сортирует элементы последовательности в порядке убывания
        int c = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = arr[c];
                Console.Write("{0,5}", mas[i, j]);
                c++;
            }
            Console.WriteLine();
        }
