// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// PrintNambers (a);

// void PrintNambers (int a)
// {
//     if (a<1)
//     {
//         return;
//     }
//     Console.Write(a+", ");
//     PrintNambers (a-1);
// }

// --------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число - M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число - N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N)
// {
//     Console.WriteLine("Введены неверные значения переменных");
//     return;
// }
// int sum = 0;
// PrintNambers(M, N, sum);

// void PrintNambers(int M, int N, int sum)
// {
//     if (M > N)
//     {
//         Console.WriteLine("-> " + sum);
//         return;
//     }
//     sum = sum + M;
//     PrintNambers(M + 1, N, sum);
// }

// --------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Программа вычисления функции Аккермана");
Console.WriteLine();
int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");

int FunA = Akf(m, n);

Console.Write("A(m,n) = " + FunA);

int Akf(int m, int n)
{
    if (m == 0)
    {
        return
        n + 1;
    }
    else

      if (n == 0)
    {
        return
        Akf(m - 1, 1);
    }
    else

        return

        Akf(m - 1, Akf(m, n - 1));
}

int ReadInt(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
