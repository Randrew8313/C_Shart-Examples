/*Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}


int[,] GetRandArray(int row, int colums, int minValue = -10, int maxValue = 10)
{
    int[,] matrix = new int[row, colums];
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;   
}

void MainDiagSumArray(int[,] matrix)
{
    int res = default;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j)
            {
               res = res + matrix[i, j];
               
            }
        }
    }
    Console.Write($"Сумма элементов главной диагонали: {res}");   
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            Console.Write($"[{i},{j}]{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int row = SetNumber("Введите количество строк массива: ");
int col = SetNumber("Введите количество столбцов массива: ");
Console.WriteLine();
int[,] result = GetRandArray(row, col);
PrintArray(result);
Console.WriteLine();
MainDiagSumArray(result);
