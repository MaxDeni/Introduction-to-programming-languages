//43. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

using System;

int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();

string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int k=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>0)
        k++;

System.Console.WriteLine(k);


/*
Console.Clear();

Console.Write($"Введи количество чисел: ");
int m=Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers=new int[m];

void InputNumbers(int m)
{
for (int i=0; i<m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i]=Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massiveNumbers)
{
  int count=0;
  for (int i=0; i<massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i]>0 ) count+=1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
*/