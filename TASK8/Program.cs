//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*Console.WriteLine("Введите число а");
int a = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

int a = 1;
while (1 <= b);
{
    if (i % 2 == 0)
    Console.Write(i + "");
    i++;
}*/
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= a)
{
    if (i % 2 == 0)
    Console.WriteLine($"{i} ");
    i++;
}