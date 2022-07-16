//Написать программу вычисления произведения чисел от 1 до N

int i=1;
int k=1;
int N=6;
while(i<=N)
{
    k=i*k;
    i++;
}
System.Console.WriteLine(k);
