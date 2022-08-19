//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int N=3;
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

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1)-1;j++)
    {
        for(int z=0;z<a.GetLength(1)-1;z++)
        {
            if(a[i,z]<a[i,z+1])
            {
                int temp=0;
                temp=a[i,z];
                a[i,z]=a[i,z+1];
                a[i,z+1]=temp;
            }
        }
    }
}

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}
