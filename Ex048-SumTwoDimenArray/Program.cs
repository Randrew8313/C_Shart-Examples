/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    //return Convert.ToInt23(Console.Readline()); - альтернативный способ ввода числа
    return result;
}

int[,] GetArray(int row, int colums)
{
    int[,] matrix = new int[row, colums];
     for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            matrix[i, j] = i + j;
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

int row = SetNumber("Введите количество строк массива: ");
int col = SetNumber("Введите количество столбцов массива: ");
int[,] result = GetArray(row, col);
PrintArray(result);
