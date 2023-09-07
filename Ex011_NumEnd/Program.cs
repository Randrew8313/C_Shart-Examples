// Программа, которая принимает трехзначное число и на выходе показывет последнюю цифру этого числа

Console.Write("Введите любое трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if((num / 100 > 0) && (num / 100 < 10))
{
    num = num % 10;
    Console.Write("Полседняя цифра числа: ");
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
