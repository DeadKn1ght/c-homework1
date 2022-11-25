Console.Clear();

Console.WriteLine("Input number1 : ");
int number1 = int.Parse(Console.ReadLine()) ; 
Console.WriteLine("Input number2 : ");
int number2 = int.Parse(Console.ReadLine()) ; 
if(number1>number2)
    Console.WriteLine("number1 more that number2") ;
 else
    if (number2 == number1)
    Console.WriteLine("numbers are equal") ;
    else 
    Console.WriteLine("number2 more that number1") ;  

