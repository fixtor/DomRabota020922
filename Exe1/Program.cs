// 64. Задайте значение M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(m,n);

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    
    if (start == end) return;
    PrintNumbers(start + 1, end);
}