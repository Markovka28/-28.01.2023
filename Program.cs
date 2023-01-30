/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

Console.Write("Введите размеры массива через пробел: ");
string[] num = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] matrix = GetArray(new int[] {int.Parse(num[0]), int.Parse(num[1]), int.Parse(num[2])}, 10,99);
PrintArray(matrix); 
int[,,] GetArray(int[] index, int min, int max)
{
    int[,,] result = new int [index[0], index[1], index[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                int element = new Random().Next(min, max +1);
                if (Findelement(result, element)) continue;
                  {
                    result[i,j,k] = element;
                    k++;
                  }
            }
        }
    }
    return result;
}
bool Findelement (int[,,] matrix, int el)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i,j,k]== el) return true;
            }
        }
    }
    return false;
    
}
void PrintArray(int[,,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]} ({i} {j} {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

/*этот код разбирали с преподавателем но он не работает в чем там ошибка я не разобрался потратил 3 часа и не смог, если поможете будет превосходно код ниже использовал по примеру из интернета*/

/*Console.WriteLine($"Введите размер массива X x Y x Z: ");
int a = Mass3D("Введите длину строки: ");
int b = Mass3D("Введите высоту столбцов: ");
int c = Mass3D("Введите глубину массива: ");
Console.WriteLine($" ");

int[,,] matrix = new int[a, b, c];
GetArray(matrix);
PrintArray(matrix);

int Mass3D(string num)
{
  Console.Write(num);
  int element = Convert.ToInt32(Console.ReadLine());
  return element;
}

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void GetArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}*/