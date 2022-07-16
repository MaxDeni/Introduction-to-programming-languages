//С клавиатуры вводится целое число из диапазона [10, 99]. Показать наибольшую цифру числа.

int a,b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

b=a/10;
c=a%10;
if (b>c)
{
System.Console.WriteLine(b);
}
else
{
System.Console.WriteLine(c);
}