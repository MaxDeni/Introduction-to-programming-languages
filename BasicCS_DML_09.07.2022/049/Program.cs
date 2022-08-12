//49. Показать двумерный массив размером m×n заполненный вещественными случайными числами

int N=2;
int M=3;

double[,] a;//описываем массив

a=new double[N,M];//создаём массив
//инициализация случайными числами
Random random=new Random();//создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=random.NextDouble()*20-3;
    }
}

//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]:F2} ");
        System.Console.WriteLine();
}

