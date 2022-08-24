//Написать программу вычисления произведения чисел, числа N

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 1;
    int result = 1;

    for (int i = 1; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result * (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Произведение чисел: " + sumNumber);