// Начало
Console.WriteLine("Hello, World!");

int minLimitRandom = -10;
int maxLimitRandom = 10;
Random rnd = new Random();
double a = Math.Round(minLimitRandom + rnd.NextDouble() * maxLimitRandom, 2);

Console.WriteLine(a);