// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberWork = Convert.ToString(Number);
if (NumberWork.Length > 2)
{
  Console.WriteLine("третья цифра: " + NumberWork[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
