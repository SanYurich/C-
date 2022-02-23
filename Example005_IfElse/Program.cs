Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вася")
{
    Console.WriteLine("Ура, это же Васёк!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}