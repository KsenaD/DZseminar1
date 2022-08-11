//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine(" Введите первое число: ");
 int FirstNumber=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(" Введите второе число: ");
 int SecondNumber=Convert.ToInt32(Console.ReadLine());
if(FirstNumber>SecondNumber)
{
    Console.WriteLine(FirstNumber+" - большее число ");
    Console.WriteLine(SecondNumber+"- меньшее число");
}
else
{
    Console.WriteLine(SecondNumber+"- большее число ");
    Console.WriteLine(FirstNumber+"- меньшее число");
}


