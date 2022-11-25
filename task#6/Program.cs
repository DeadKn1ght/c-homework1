// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Input number1 : ");
int number1 = int.Parse(Console.ReadLine()) ; 
if (number1%2 == 0)
    Console.WriteLine("Number1 is even");
    else
    Console.WriteLine("Number1 is not even");