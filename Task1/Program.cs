/* 1. Напишите программу, которая принимает
на вход трёхзначное число и на выходе
показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 */
Console.Write("Введите трёхзначное число: ");
string istring = Console.ReadLine();
int num = int.Parse(istring);
int a = int.Parse(Convert.ToString(num)[0].ToString());
int b = int.Parse(Convert.ToString(num)[1].ToString());
int c = int.Parse(Convert.ToString(num)[2].ToString());
Console.Write($"Последняя цифра числа: {c}");