//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

int b=a%100;
int c=b/10;

System.Console.WriteLine(c);