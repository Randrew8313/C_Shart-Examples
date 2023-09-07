// Приложение с оператором цикла

Console.Clear();

int xa = 40, ya = 1,
    xb = 0, yb = 40,
    xc = 80, yc = 40;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //Генератор случайных чисел от 0 до 3 - [0,3) т.е 0 1 2
    if(what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

        if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++; //Краткая запись прибавления единички в цикле While
}