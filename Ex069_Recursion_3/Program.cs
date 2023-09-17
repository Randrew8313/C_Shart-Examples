//Задача 69: Напишите задачу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.

double Pow(double num, double rank)
{
    if(rank < 0)
    {
        return 1 / (num * Pow(num, rank + 1));
    }

    if(rank == 0)
    {
        return 1;
    }

    if(rank == 1)
    {
       return num;
    }

   return num = num * Pow(num, rank - 1);
}

Console.Write(Pow(2, -1));