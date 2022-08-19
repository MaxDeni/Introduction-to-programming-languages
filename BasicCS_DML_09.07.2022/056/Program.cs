//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int N=4;
int M=4;

int [,] a;

a=new int [N,M];

Random random=new Random();

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,10);
    }
}

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

System.Console.WriteLine();

int minsum=Int32.MaxValue;
int indexLine=0;

for(int i=0;i<a.GetLength(0);i++)
{
    int sum=0;
    for (int j=0;j<a.GetLength(1);j++)
    {
        sum=sum+a[i,j];        
    }
    if (sum<minsum)
    {
        minsum=sum;
        indexLine++;
    }
}

Console.WriteLine("Cтрока " + (indexLine));
