//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string PrintNumbers(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start + 1, end);
}

Console.Write(PrintNumbers(1, 1000));