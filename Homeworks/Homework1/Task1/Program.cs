// Задача 1: Проверка кратности числа 7 и 23

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("Кратно");
        }
        else
        {
            Console.WriteLine("Не кратно");
        }
    }
}