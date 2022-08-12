//46. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
/*
Console.Write($"Введи количество чисел: ");
int n=Convert.ToInt32(Console.ReadLine());
*/
/*
int n=int.Parse(Console.ReadLine());
int fibonacchi(int n)
*/
int n;
Console.Write("Введите число N: ");
string? s=Console.ReadLine();
n=Convert.ToInt32(s);
int fibonacchi(int n)

{
    if (n==1 || n==2) return 1;
    else return fibonacchi(n-1) + fibonacchi(n-2);
}

for (int i=1; i<=n; i++)
{
    System.Console.WriteLine(fibonacchi(i));
}
