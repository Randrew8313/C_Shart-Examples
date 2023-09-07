// Вывести все числа от "-n" до "n".

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());

int otrNum = - num;

while(otrNum <= num)
{
    Console.WriteLine(otrNum);
    otrNum++;
}