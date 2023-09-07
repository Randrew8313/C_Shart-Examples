// Программа, которая проверяет, является-ли одно число квадратом второго

Console.Write("Введите первое чило: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
if(numA * numA == numB)
{
    Console.WriteLine("Второе число является квадратом первого!");
}
else if(numB * numB == numA)
{
    Console.WriteLine("Первое числоя является квадратом второго!");
}
else
{
    Console.WriteLine("Числя не являются квадратом друг другу.");
}