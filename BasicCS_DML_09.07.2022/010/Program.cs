//Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

/*
int a=5018932;
int b=a%10;
System.Console.WriteLine(b);
*/

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

int b=a%10;
System.Console.WriteLine(b);
