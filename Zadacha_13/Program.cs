Console.WriteLine("Введите число:");
string n1 = Console.ReadLine();
int n = int.Parse(n1);

if (n<0)
{
    n = -n;
}

if (n/100 == 0)
{
   Console.WriteLine("Третьей цифры у числа нет."); 
}
else
{
while (n>1000)
{
    n = n/10;
}

int x = n%10;

Console.Write("Третьей цифрой введённого числа является ");
Console.WriteLine(x);
}