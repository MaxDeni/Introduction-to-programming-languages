//С клавиатуры вводятся три числа. Найти максимальное из трех чисел


//Проверять является ли одно из них квадратом второго
int a,b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
//==,!=,>,<,>=,<=
if (a>=b)
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
        System.Console.WriteLine("a является квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
} 