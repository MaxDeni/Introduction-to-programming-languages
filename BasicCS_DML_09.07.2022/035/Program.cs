﻿//Написать программу замены элементов массива на противоположные.

int[] t;
Init(out t,8,0,25);
Print(t,"t");
void Init(out int[] t, int Length,int min,int max)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1)*(-1);
}

void Print(int[] t, string variableName)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{variableName}[{i}]={t[i]} ");
}