// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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
    for (int i = m; i <= n; i++)
    {
        System.Console.Write($"{i, 3}");
    }
}

PrintResult(GetM(),GetN());
