﻿//Создать массив целых чисел NxM и заполнить его случайными числами от 1 до 10. Вывести массив на экран

int N=2;
int M=3;

int[,] a;//описываем массив

a=new int[N,M];//создаём массив
//инициализация случайными числами
Random random=new Random();//создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=random.Next(1,11);
    }
}



//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
        System.Console.WriteLine();
}
