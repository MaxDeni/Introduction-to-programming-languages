//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
bool b,c,d;
int x=7;
b=x>5;
c=x<8;
d=b && c;
if (d)
{
    System.Console.WriteLine($"{x} номер дня недели является выходным");
}
else
{
    System.Console.WriteLine($"{x} номер дня недели не является выходным");
}

/*
int a=2;
if ((a>5) && (a<8))
{
    System.Console.WriteLine("номер дня недели является выходным");
}
else
{
    if ((a>0) && (a<6))
    {
        System.Console.WriteLine("номер дня недели не является выходным");
    }
    else
    {
        System.Console.WriteLine("номер не является днём недели");
    }
}
*/

