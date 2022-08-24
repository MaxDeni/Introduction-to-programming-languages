//Написать программу вычисления значения функции y = sin(a). (Класс Math)
/*double x,y;
//x=3.1415;
x=Math.PI;
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");

double r=1.0/3+1.0/3;
System.Console.WriteLine(r);
*/

//тип возвращаемого значения Имя_фунции(аргументы функции)
double Sin(double x)//метод
{
    return Math.Sin(x);
}

/*
double Sum(double a, double b)
{
    return a+b;
}

double Sum(int a, int b)
{
    return a+b;
}
*/

void Pause()//метод
{
    System.Console.WriteLine("Press any key");
}

double y=Sin(3.14);
System.Console.WriteLine(y);
Pause();
//System.Console.WriteLine(Pause());

