/*Задача 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.*/
internal class Program
{
    private static void Main(string[] args)
    {
    void SummNumbers(int a, int b)
        {
            if (a >= b)
            {
                SummNumbers(a - 1, b);
                Console.WriteLine(a);
            }
        }
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if ((n > m))
        {
            SummNumbers(n, m);
             
        }
        if (m > n)
        {
            SummNumbers(m, n);
        }
        int sum = 0;
        for (int i = n; i<=m ; i++)
        {
           sum +=i; 
        }
        Console.WriteLine($"Сумма чисел в диапазоне {sum}");
    }
}