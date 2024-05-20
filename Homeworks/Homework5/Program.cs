// //Задача 1: Создание строки из двумерного массива символов
// public class Task1
// {
//     public static void Main(string[] args)
//     {
//         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
//         string result = CreateStringFrom2DArray(charArray);
//         Console.WriteLine(result);
//     }
//     public static string CreateStringFrom2DArray(char[,] array)
//     {
//         string result = "";
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 result += array[i, j];
//             }
//         }
//         return result;
//     }
// }


// //Задача 2: Замена заглавных букв на строчные в строке
// public class Task2
// {
//     public static void Main(string[] args)
//     {

//         string result = input.ToLower();
//         Console.WriteLine(result);
//     }
// }


// //Задача 3: Проверка строки на палиндром
// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         string input = "шалаш";
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
// {
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }

// //Задача 4: Обратный порядок слов в строкеpublic class Task4
// {
//     public static void Main(string[] args)
//     {
//         string input = "Hello my world";
//         string result = ReverseWords(input);
//         Console.WriteLine(result);
//     }
//     public static string ReverseWords(string str)
//     {
//         string[] words = str.Split(' ');
//         Array.Reverse(words);
//         return string.Join(" ", words);
//     }
// }