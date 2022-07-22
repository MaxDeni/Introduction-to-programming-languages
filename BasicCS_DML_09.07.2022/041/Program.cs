//41. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] array=new double[10];
  for (int i=0; i<array.Length; i++)
  {
    array[i]=new Random().Next(1, 10);
    System.Console.Write(array[i]+ " ");
  }
double max=array[0];
double min=array[0];
  for (int i=1; i<array.Length; i++)
  {
    if (max<array[i])
    {
      max=array[i];
    }
        if (min>array[i])
    {
      min=array[i];
    }
  }
double d=max-min;
System.Console.WriteLine("Разница между между максимальным и минимальным элементами равна: " + d);
