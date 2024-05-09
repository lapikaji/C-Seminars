// // void NumToQuad(int a)
// // {
// //     Console.WriteLine(a * a);
// // }

// int  NumToQuadInt(int a)
// {
//     return a * a;
// }

// Console.WriteLine("InputNumber: ");
// int a = Convert.ToInt32(Console.ReadLine());

// //NumToQuad(a);
// //int result = NumToQuadInt(a);
// //Console.WriteLine(result);
// Console.WriteLine(NumToQuadInt(a));


// 2. Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int  DelSecondDigit(int a)
// {
//     if (a >= 100 && a <= 999)
//     {
//         return (a / 100 * 10) + (a % 10);
//     }
//     else
//     {
//         Console.WriteLine("Wrong number of digits");
//         return a;
//     }

// }

// Console.WriteLine("InputNumber: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DelSecondDigit (a));

// 3.1 Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int PowSecondDigit(int a)
// {
//     if (a >= 100 && a <= 999)
//     {
//         return (int)Math.Pow((a / 10) % 10, a % 10);
//     }
//     else
//     {
//         Console.WriteLine("Wrong number of digits");
//         return a;
//     }
// }

// Console.WriteLine("InputNumber: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PowSecondDigit (a));

// 3.2 Решение через цикл

// int PowSecondDigit(int a)
// {
//     if (a >= 100 && a <= 999)
//     {
//         int ed = a % 10;
//         int dec = a / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         Console.WriteLine("Wrong number of digits");
//         return a;
//     }
// }

// Console.WriteLine("InputNumber: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PowSecondDigit (a));

// 4. Напишите программу, которая принимает на вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void CheckIfDevides(int num1, int num2)
// {
//     if( num1 % num2 == 0)
//     {
//         Console.WriteLine($"{num1}, {num2} -> Yes");
//     }
//     else
//     {
//         Console.WriteLine($"{num1}, {num2} -> No, {num1 % num2}");
//     }
// }

// Console.WriteLine("InputFirstNumber: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("InputSecondNumber: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckIfDevides (num1, num2);

