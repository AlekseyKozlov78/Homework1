//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое число");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Введите второе число");
double n2 = double.Parse(Console.ReadLine ());

Console.WriteLine ("Введите третье число");
double n3 = double.Parse(Console.ReadLine ());

double max = 0;
max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.WriteLine ("max = " + max);
  
