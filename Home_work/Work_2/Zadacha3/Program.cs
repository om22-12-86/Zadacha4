// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index<number)
{
 if (index % 2 == 0)
 {
  Console.Write($"{index},");
 }
 index++;

}

