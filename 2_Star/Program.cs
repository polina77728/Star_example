/* Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

*/

Console.WriteLine("Привет! Тебе пришло секретное сообщение!");
Console.WriteLine("У тебя есть 3 попытки ввести пароль.");
Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
string parolUser = Console.ReadLine();
string exit = "exit";

while (parolUser != exit)
{
    Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
    parolUser = Console.ReadLine();

    if (parolUser == exit)
    {
        break;
    }

}