// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Natural numbers from M to N:");
PrintNatNumbers(M, N);

void PrintNatNumbers(int M, int N)

{
    if (M > N)
        {
            return;
        }

    Console.WriteLine(M);
    PrintNatNumbers(M + 1, N);
}