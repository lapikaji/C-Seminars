//Задача 2: Напишите программу вычисления функции Аккермана* с помощью рекурсии. Даны два неотрицательных числа m и n.
//*Функиця Аккрмана принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число.

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(akkerman(m, n));

int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

($"A({m},{n}) = {akkerman(m, n)} ");