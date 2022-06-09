/* Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */
Random rand = new Random();
int inum = rand.Next(10,100);
Console.Write($"Случайное число {inum}");
int a = inum%100;
int b = inum%10;
Console.Write($"Случайное число {a}{b}");
if (a > b)
{
    Console.Write($"Наибольшее число {a}");
}
else
{
    Console.Write($"Наибольшее число {b}");
} 