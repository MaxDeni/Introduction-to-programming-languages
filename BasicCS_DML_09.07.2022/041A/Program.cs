//Задача 41A. Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

int N=3;
int M=3;

int [,] a;

a=new int [N,M];

Random random=new Random();

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,3);
    }
}

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

int count;

count=0;

for (int i=0; i<a.GetLength(0); i++)
for (int j=0; j<a.GetLength(1); j++)
    {
        if (a[i,j]!=a[j,i])
        count++;
    }
if (count>0) System.Console.WriteLine("Не семмитрична");
else System.Console.WriteLine("Семмитрична");

