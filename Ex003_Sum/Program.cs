int numberA = new Random().Next(1, 100); //1 2 3 4 5 ... 99
Console.Write("Первое число ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.Write("Второе число ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("Сумма чисел = ");
Console.WriteLine(result);