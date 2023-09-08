// Код для программы сложения двух чисел

// int numberA = new Random().Next(1, 100); //1 2 3 4 5 ... 99
// Console.Write("Первое число ");
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 100);
// Console.Write("Второе число ");
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.Write("Сумма чисел = ");
// Console.WriteLine(result);

           int n = 3;
           int m = 4;
           int k = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
double[] printListAvr = FindAverageInColumns(result);

    int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
    /*Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
    с каждым новым элементом увеличивающимся на опрделенное число.
    Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
    k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.*/
    // Введите свое решение ниже
    int[,] matrix = new int[n, m];
    int start = 1;

     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == 0 && j == 0)
            {
                matrix[i,j] = start;
            }
            else
            {
                start += k;
                matrix[i,j] = start;
            }
        }
    }
    return matrix; 
    }

    double[] FindAverageInColumns (int [,] matrix)
    {
        double[] averArray = new double[matrix.GetLength(1)];
        double averageInColums;
        int index = -1;
        for(int i = 0; i < matrix.GetLength(1); i++)
        {
            averageInColums = default;
            for(int j = 0;j < matrix.GetLength(0); j++)
            {
                if(j == 0)
                {
                    index++;
                }
                averageInColums += matrix[j,i]; 
            }
            averArray[index] = averageInColums/matrix.GetLength(1);
             
        }
        return averArray;
    }