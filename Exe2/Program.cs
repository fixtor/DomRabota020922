// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
    System.Console.WriteLine("Вы ввели неверное чиcло!");
else
{
    int summ = GetSumm(m, n);
    System.Console.WriteLine(summ);
}


int GetSumm(int start, int end)
{
    if (start == end) return start;

    return end + GetSumm(start, end - 1);
}