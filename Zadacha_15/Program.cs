Console.WriteLine("Введите номер дня недели от 1 до 7:");
string n1 = Console.ReadLine();
int n = int.Parse(n1);

if (n<1 || n>7)
{
    Console.WriteLine("Номер введен неправильно.");
}

else
{
    if (n>=1 && n<=5)
    {
        Console.WriteLine("Это будний день.");
    }

    else
    {
        Console.WriteLine("Это выходной.");
    }
}