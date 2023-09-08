// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    //return Convert.ToInt23(Console.Readline()); - альтернативный способ ввода числа
    return result;
}


int[,] GetRandArray(int row, int colums, int minValue = -10, int maxValue = 10)
{
    int[,] matrix = new int[row, colums];
     for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;   
}

int[,] SqrOddIndexArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
    return matrix;   
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
result = SqrOddIndexArray(result);
Console.WriteLine();
PrintArray(result);