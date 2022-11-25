// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Input number1 : ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number2 : ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number3 : ");
int number3 = int.Parse(Console.ReadLine());

if ((number1 > number2) & (number1 > number3))
    Console.WriteLine("number1 more that number2 and number3");
else
    if ((number2 > number1) & (number2 > number3))
    Console.WriteLine("number2 more that number1 and number3");
else
        if ((number3 > number2) & (number2 > number1))
    Console.WriteLine("number3 more that number1 and number2");
    else
        if ((number1 == number2) & (number1 == number3))
        Console.WriteLine("All numbers are equal");
        else 
            if((number1 == number2) & (number1 > number3))
            Console.WriteLine("numbers1 and numbers2 are equal and more that number3");
            else 
                if ((number3 == number2) & (number3 > number1))
                Console.WriteLine("numbers3 and numbers2 are equal and more that number1");
                else 
                    if((number3 == number1) & (number3 > number2))
                    Console.WriteLine("numbers3 and numbers1 are equal and more that number2");
