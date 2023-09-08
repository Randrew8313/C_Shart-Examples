//Среднее арифметическое каждого столбца.
//Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
    //Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
    // Введите свое решение ниже
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"[{i},{j}]{matrix[i, j]}\t"); 
        }
    Console.WriteLine();
    }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
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
  
    static void PrintListAvr (double [] list)
    {
    /*Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран
    в формате "The averages in columns are: x.x0 x.x0 x.x0 ...",
    где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.*/
    // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: "); 
        string res;
        for(int i = 0; i < list.Length; i++)
        {
            res = list[i].ToString("0.00");
            Console.Write($"{res}\t");
        }
    }

    static double [] FindAverageInColumns (int [,] matrix)
    {
    /*Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double.
    Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.*/
    // Введите свое решение ниже
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
            averArray[index] = averageInColums/matrix.GetLength(0);
             
        }
        return averArray;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}