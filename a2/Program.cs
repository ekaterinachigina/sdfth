// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int KolChisel (int a)
{
  int count = 10;
  int i = 1;
  while (a >= count)
  {
    count = count*10;
    i++;
  }
  return i;
}
int il = KolChisel(a);

int SumChisel (int kol2, int a)
{
  int index = 1;
  int sum = 0;
  while (index <= kol2)
  {
    sum = sum + a % 10;
    a = a / 10;
    index++;
  }
  return sum;
}
Console.WriteLine($"{a} -> {SumChisel(il, a)}");