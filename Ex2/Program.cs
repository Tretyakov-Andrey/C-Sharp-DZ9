// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int GetM()
{
    int m = new Random().Next(1,6);
    System.Console.WriteLine($"M = {m}");
    return m;
}

int GetN()
{
    int n = new Random().Next(6,16);
    System.Console.WriteLine($"N = {n}");
    return n;
}

void PrintResult(int m, int n)
{
    int res = 0;
    for (int i = m; i <= n; i++)
    {
        res = res + i;
    }
    System.Console.WriteLine(res);
}

PrintResult(GetM(),GetN());