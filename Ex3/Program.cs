// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int GetM()
{
    int m = 2;
    return m;
}

int GetN()
{
    int n = 3;
    return n;
}

int Result(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return Result(M - 1, 1);
    }
    else
    {
        return Result(M - 1, Result(M, N - 1));
    }
}

void Print(int Res)
{
    System.Console.WriteLine(Res);
}

Print(Result(GetN(), GetM()));