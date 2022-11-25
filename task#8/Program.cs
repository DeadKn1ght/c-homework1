// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Input number N : ");
int N = int.Parse(Console.ReadLine()) ; 
int Y = 2;
Console.WriteLine("All equal numbers before N are : ") ;
while (Y <= N)  
{
    Console.WriteLine(Y);

 Y = Y+2;
}
