//37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

int[] a;
int b;
int c;
Init(out a,8,100,999);
Print(a);

Solve(a,out b, out c);
System.Console.WriteLine("Количество чётных чисел = " + b); 
System.Console.WriteLine("Количество нечётных чисел = " + c);

void Init(out int[] t, int Length,int min,int max)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{t[i]} ");
}

void Solve(int[] a,out int b, out int c)
{
    b=0;
    c=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2==0)
            b=b+1;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2!=0)
            c=c+1;
}