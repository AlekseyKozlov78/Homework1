//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string str = Console.ReadLine();
int n = str.Length;
if (n == 3) 
{    
    Console.WriteLine("Последняя цифра числа равна ");  
    Console.WriteLine(str[n-1]); 
}
else 
    Console.WriteLine("Вы ввели не трехзначное число ");