/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

int InputNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    //return Convert.ToInt23(Console.Readline()); - альтернативный способ ввода числа
    return result;
}

int[,] GetRandArray(int [,] matrix, int minValue = -10, int maxValue = 10)
{
     for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int row = InputNumber("Введите количество строк массива: ");
int col = InputNumber("Введите количество столбцов массива: ");
int[,] matr = new int[row, col];
GetRandArray(matr);
PrintArray(matr);