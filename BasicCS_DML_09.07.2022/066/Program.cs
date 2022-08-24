//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine());

void GapSum (int M, int N, int sum)
{
    if(M>N) 
    {
        System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
        return;
    }
    sum=sum+(M++);
    GapSum(M,N,sum);
}

GapSum(M,N,0);