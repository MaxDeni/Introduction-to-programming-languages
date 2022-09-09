//Задача:
/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

System.String[] a1=new string[7] {"Russia", "2", "-2", ":-)", "1567", "computer science", "Denmark"};
System.String[] a2=new string[a1.Length];
void SecondArray(string[] a1,string[] a2)
{
    int count=0;
    for(int i=0; i<a1.Length;i++)
    {
        if(a1[i].Length<=3)
            {
                a2[count]=a1[i];
                count++;
            }
    }
}
void PrintArray(string[] a2)
{
    for(int i=0;i<a2.Length;i++)
    {
        System.Console.Write($"{a2[i]} ");
    }
    System.Console.WriteLine();
}
SecondArray(a1,a2);
PrintArray(a2);

