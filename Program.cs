//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine(" Введите первое число: ");
// int FirstNumber=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите второе число: ");
// int SecondNumber=Convert.ToInt32(Console.ReadLine());
// if(FirstNumber>SecondNumber)
// {
//     Console.WriteLine(FirstNumber+" - большее число ");
//     Console.WriteLine(SecondNumber+"- меньшее число");
// }
// else
// {
//     Console.WriteLine(SecondNumber+" большее число ");
//     Console.WriteLine(FirstNumber+"- меньшее число");
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine(" Введите первое число: ");
// int FirstNumber=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите второе число: ");
// int SecondNumber=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите третье число: ");
// int ThirdNumber=Convert.ToInt32(Console.ReadLine());
// if(FirstNumber>SecondNumber)
// {
//     if(FirstNumber>ThirdNumber)
//     Console.WriteLine("максимальное число "+FirstNumber);
//     else
//     Console.WriteLine("максимальное число  "+ThirdNumber);
//    }
// else
// {
//      if(SecondNumber>ThirdNumber)
//     Console.WriteLine("максимальное число "+SecondNumber);
//     else
//     Console.WriteLine("максимальное число  "+ThirdNumber);
// }

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine(" Введите число: ");
// int FirstNumber=Convert.ToInt32(Console.ReadLine());
// if (FirstNumber%2==0)
// {
//     Console.WriteLine(FirstNumber+" чётное число");
// }
// else
// {
//     Console.WriteLine(FirstNumber+ " нечётное число");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine(" Введите число: ");
int Number=Convert.ToInt32(Console.ReadLine());
int A=1;
while (A<=Number)
{
   if(A%2==0)
   Console.Write(A+", "); 
    A++;
 }
