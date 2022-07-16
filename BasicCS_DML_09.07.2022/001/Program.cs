// See https://aka.ms/new-console-template for more information
//комментарии
//С клавиатуры вводится целое число. Вывести квадрат числа 
/*
Console.WriteLine("Hello, World!");
System.Console.WriteLine(11%3);

int MaxFromToNumbers=0;
double d=3.14;
System.Console.WriteLine(int.MaxValue);
Console.WriteLine(double.MaxValue);
string s="Hello";//конкатенация строк (склеивание)
char c='a';
*/

/*
int a=100;
int b;
b=a*a;
System.Console.WriteLine("{0}^2={1}",a,b);//строка форматирования
System.Console.WriteLine($"{a}^2={b}");//строка интерполяции
*/


/*string? s;//объявили
s=Console.ReadLine();//присвоили

System.Console.WriteLine(s);
*/

double a=3.14;
double b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToDouble(s);


b=a*a;//обработка данных

//вывод результата
System.Console.WriteLine("{0}^2={1}",a,b);//строка форматирования
System.Console.WriteLine($"{a}^2={b}");//строка интерполяции
