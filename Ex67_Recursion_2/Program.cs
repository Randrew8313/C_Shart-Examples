// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int GetSum(int num)
{
    if(num == 0)
    {
        return num;
    }
    return num % 10 + GetSum(num / 10);
}

Console.Write(GetSum(453));