/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
using System;
class RecExercise1
{
    static void Main()
    {
	Console.Write("Введите число: ");
	int N = Convert.ToInt32(Console.ReadLine());
	Revers(N, 1);
	Console.Write(" ");
    }
    static int Revers(int start, int end)
    {
	if (start < 1)
	{
	    return end;
	}
	Console.Write(" {0} ", start);
		start--;
	return Revers(start, end);
    }
}


