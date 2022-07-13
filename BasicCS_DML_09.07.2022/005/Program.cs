//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a,b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);

if ((b>a && c>b) || (a>b && c>a))
{
    System.Console.WriteLine("c является максимальным числом");
}
else
{
    if (a>b && a>c)
    {
        System.Console.WriteLine("a является максимальным числом");
    }
    else
    {
        System.Console.WriteLine("b является максимальным числом");
    }
} 
