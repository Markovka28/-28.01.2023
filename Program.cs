/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. */

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int arg = Convert.ToInt32(Console.ReadLine());
AckermanFunction(num, arg);         
int AckermanFunction(int num, int arg)
{
if (num == 0) 
{
    return arg + 1;
}
if (num != 0 && arg == 0) 
{
    return AckermanFunction(num - 1, 1);    
}
if (num > 0 && arg > 0) 
{
    return AckermanFunction(num - 1, AckermanFunction(num, arg - 1));
}
return AckermanFunction(num,arg);
}
Console.WriteLine($"Функция Аккермана({num},{arg}) = {AckermanFunction(num, arg)}");