/* Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23.
14 -> нет
46 -> нет
161 -> да */
Console.WriteLine("Программа проверики числа на кратность 7 и 23");
Console.Write("Введите число: ");
string inum = Console.ReadLine();
int num = int.Parse(inum);
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23 одновременно");
}