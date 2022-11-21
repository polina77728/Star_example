/* В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/


string message = "ПОРА ПООБЕДАТЬ! УРА!";
string parol = "123456789";
int index = 1;


Console.WriteLine("Привет! Тебе пришло секретное сообщение!");
Console.WriteLine("У тебя есть 3 попытки ввести пароль.");
Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
string parolUser = Console.ReadLine();


while (index < 3 && parolUser != parol || parolUser == parol)
{
    index++;

    if (parolUser == parol)
    {
        Console.WriteLine(message);
        break;
    }

    else
    {
        Console.WriteLine("ВВЕДИТЕ ПАРОЛЬ: ");
        parolUser = Console.ReadLine();
    }

}