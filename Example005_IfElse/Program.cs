Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "eldar")
{
    Console.WriteLine("Yes, it is Eldar!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}