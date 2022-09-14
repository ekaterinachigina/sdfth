// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int Multiplication(int a, int b)
{
    int multi = 1;
    int index = 1;
    while (index <= b)
    {
        multi = multi * a;
        index++;
    }
    return multi;
}
Console.WriteLine($"{a},{b} -> {Multiplication(a, b)}");