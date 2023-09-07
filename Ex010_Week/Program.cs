// Программа, которая показывает день недели по введенному номеру.
Console.Write("Введите чило от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("Понедельник");
}
else if(num == 2)
{
    Console.WriteLine("Вторник");
}
else if(num == 3)
{
    Console.WriteLine("Среда");
}
else if(num == 4)
{
    Console.WriteLine("Черверг");
}
else if(num == 5)
{
    Console.WriteLine("Пятница");
}
else if(num == 6)
{
    Console.WriteLine("Суббота");
}
else if(num == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Внимание! Вводите числа от 1 до 7.");
}