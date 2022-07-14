//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Д О Д Е Л А Т Ь ! ! ! ! ! !
 
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a%10;
int c=a/10%10;
if ((a>99) && (a<1000))
{
    System.Console.WriteLine(b);
}
else
if ((a>999) && (a<10000))
{
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}
/*
else
if (a>999)
int b=
{
    System.Console.WriteLine("третьей цифры нет");
}
*/


/*
int A=987;
{
 int s=0;
 for (int i=1; i<=A; i++)
 {
 s=s+i;
 }
System.Console.WriteLine(s);
}
*/