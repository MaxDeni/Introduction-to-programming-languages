//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}