/* Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

*/


string message = "ПОРА ПООБЕДАТЬ! УРА!";
string parol = "123456789";
string exit = "exit";


Console.WriteLine("Привет! Тебе пришло секретное сообщение!");
Console.WriteLine("У тебя есть 3 попытки ввести пароль.");
Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
string parolUser = Console.ReadLine();


while (parolUser != parol || parolUser == parol)
{

    if (parolUser == parol)
    {
        Console.WriteLine(message);
        break;
    }

    else if (parolUser == exit)
    {
        break;
    }

    else
    {
        Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
        parolUser = Console.ReadLine();
    }
}
