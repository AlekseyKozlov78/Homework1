//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int n2 = int.Parse(Console.ReadLine ());

if (n1 > n2)
{
    Console.WriteLine ("max = " + n1);
    Console.WriteLine ("min = " + n2);
}
else
    {
    Console.WriteLine ("max = " + n2);
    Console.WriteLine ("min = " + n1);
}
