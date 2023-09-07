// Код для персонального приветствия

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Ура! Это же Андрей!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}