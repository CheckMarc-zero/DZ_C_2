Console.WriteLine("Введите трехзначное число:");
string n1 = Console.ReadLine();
int n = int.Parse(n1);

int x = n%100/10;

if (x<0)
{
    x = -x;
}

Console.Write("Второй цифрой введённого числа является ");
Console.WriteLine(x);