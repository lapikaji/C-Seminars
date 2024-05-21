//// Задча 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 3, 4, 5, 6 };
// PrintArrayReversed(array, array.Length - 1);


// void PrintArrayReversed(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write(array[index] + " ");
//         PrintArrayReversed(array, index - 1);
//     }
// }

//  ______________ консольный ввод vvv _____________ 

Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine("Input array elements:");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Reversed array elements:");

PrintArrayReverse(array, array.Length - 1);
void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);
}