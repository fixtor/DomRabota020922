// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{FuncAccer(m, n)} ");

int FuncAccer(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FuncAccer(m - 1, 1);
    return FuncAccer(m - 1, FuncAccer(m, n - 1));
}
