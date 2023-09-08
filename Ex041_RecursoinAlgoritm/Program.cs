/*
String.Empty - по умолчанию для строк инициализация происходит вот с такой константой.
Массив table[3, 5] выглядит так:
table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
table[2,0]  table[2,1]  table[2,2]  table[2,3]  table[2,4]
*/

string[,] table = new string[3, 5]; // Объявление нового двумерного массива.
table[1, 2] = "Слово";
for(int rows = 0; rows < 3; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
        Console.WriteLine();
}

void FillArray(int [,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }   
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matr = new int[3, 4];
PrintArray(matr);
FillArray(matr);
PrintArray(matr);