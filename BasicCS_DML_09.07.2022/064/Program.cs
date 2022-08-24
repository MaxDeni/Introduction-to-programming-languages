//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/

System.Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>M)
for (int i=M;i<=N;i++)
    System.Console.Write($" {i}");
else
    for (int i=N;i<=M;i++)
        System.Console.Write($" {i}");