//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//!(X || Y)==!X and !Y
/*
int N=10;
int i=0;
while(i<N)//пока - универсальный
{
    i=i+1;
    System.Console.Write($"{i} ");
}
//for
for(i=0;i<N;i=i+1)
{
    System.Console.Write($"{i} ");
}
//do
int a;
do
{
    System.Console.WriteLine("Введите положительное число:");
    a=Convert.ToInt32(Console.ReadLine());
}
while(a<=0);
*/

//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//!(X || Y)==!X && !Y

int N=5;
System.Console.WriteLine($"N={N}");
bool x,y,f1,f2,f;
x=true;
y=true;
f1=!(x || y);
f2=!x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");
