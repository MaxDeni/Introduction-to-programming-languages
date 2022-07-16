//Защита от дурака
string s;
int n;
bool f;
do
{
    s=Console.ReadLine();
    f=int.TryParse(s,out n);
    if (f==false) System.Console.WriteLine("Wrong input!");
}
while(f==false);
System.Console.WriteLine(n);

/*
void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}
void Calc(int a, int b, ref int sum,ref int sub)
{
    sum=a+b;
    sub=a-b;
}
int a,b,sum,sub;
a=1;
b=2;
Calc(a,b,ref sum, ref sub);
*/
/*
System.Console.WriteLine($"{a} {b}");
Swap(ref a,ref b);
System.Console.WriteLine($"{a} {b}");
*/
/*
int a,b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
a=a+b;
b=a-b;
a=a-b;
System.Console.WriteLine($"{a} {b}");
*/