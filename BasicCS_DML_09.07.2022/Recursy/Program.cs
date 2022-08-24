//Вывести числа от 1 до N без использования циклов
/*
void Loop(int i, int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}

int F(int n)
{
    if (n>0) return F(n-1)*n;
    else return 1;
}
System.Console.WriteLine(F(5));

//Loop(1,10);
*/
/*
int P(int a, int b)
{
    if (b==0) return 1;
    if (b%2!=0) return P(a,b-1)*a; 
    else  return P(a,b/2)*P(a,b/2);
}

System.Console.WriteLine(P(2,10));
*/

//Задача 1. Найти сумму элементов от M до N, N и M заданы

int P(int M, int N)
{
    if (M==N) return M;
    else return P(M+1,N)+ M;
}
System.Console.WriteLine(P(1,10));
