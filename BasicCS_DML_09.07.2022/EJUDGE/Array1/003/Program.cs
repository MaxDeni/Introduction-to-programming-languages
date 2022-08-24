//
/*
003
Вводится сначала число N, а затем N чисел. Выведите эти N чисел в следующем порядке: сначала выводятся числа, стоящие на нечетных местах, а затем - стоящие на четных местах. Нумерация элементов начинается с 0. Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Примеры
Входные данные
5
1 2 3 4 5

2 4 1 3 5
*/
/*
using System;

int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
//s=s.Trim();//удалить пробелы в начале и конце строки
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);

for(int i=1;i<a.Length;i=i+2)
    System.Console.WriteLine($"{a[i]} ");
for(int i=1;i<a.Length;i=i+2)
    System.Console.WriteLine($"{a[i]} ");
*/
<<<<<<< HEAD


=======
>>>>>>> 3a018f75bdef607eafe13a13fd60f23b55a06e57
using System;
int n=Convert.ToInt32(Console.ReadLine());
string? s=Console.ReadLine();
//s=s.Trim();//удалить пробелы в начале и конце строки
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
<<<<<<< HEAD
int[] a=Array.ConvertAll<string,int>(ss, Convert.ToInt32);
=======
int[] a=Array.ConvertAll<string,int>(ss, Convert.ToUInt32);
>>>>>>> 3a018f75bdef607eafe13a13fd60f23b55a06e57

for(int i=0;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");    
for(int i=1;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");
<<<<<<< HEAD
=======

>>>>>>> 3a018f75bdef607eafe13a13fd60f23b55a06e57
